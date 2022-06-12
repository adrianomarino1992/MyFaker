using MyFaker.Interfaces;
using MyRefs.Extensions;

using System.Linq.Expressions;
using System.Reflection;

using static MyRefs.Extensions.ReflectionExtension;

namespace MyFaker.Objects
{
    public abstract class Faker<T> : IFaker<T> where T : class
    {
        private List<Rule> _rules;

        public Faker()
        {
            _rules = new List<Rule>();

            ConstructorInfo ctor = typeof(T).GetConstructors().First(c => c.GetParameters().Count() == 0);

            if (ctor is null)
                throw new Exceptions.ContructorNotFoundException(typeof(T));
        }

        public Faker<T> AddRule<U>(Expression<Func<T, U>> expression, Func<Data.FakeData, object> func)
        {
            if (!expression.IsMemberAcess())
                throw new ArgumentException($"The {nameof(expression)} must be a {typeof(MemberExpression).Name}");

            PropertyInfo? info = expression.GetPropertyInfoOfExpression();

            if (info == null)
                throw new Exceptions.InvalidCastException($"Fail on acess the property in the expression {expression}");

            if (_rules.Any(r => r.Property.Equals(info)))
            {
                throw new Exceptions.RuleAlreadyExistsException(_rules.First(r => r.Property.Equals(info)));
            }

            _rules.Add(new Rule(info, func));

            return this;
        }

        public T Get()
        {
            PropertyInfo[]? props = GetPublicProperties(typeof(T), d => true);

            ConstructorInfo ctor = typeof(T).GetConstructors().First(c => c.GetParameters().Count() == 0);

            if (ctor is null)
                throw new Exceptions.ContructorNotFoundException(typeof(T));

            T o = (T)ctor.Invoke(new object[] { });

            if (props == null)
                return o;

            foreach (PropertyInfo? info in props)
            {
                Rule? r = _rules.FirstOrDefault(s => s.Property.Equals(info));

                if (r != null)
                {
                    object obj = r.GetValue(Data.FakeData.Instance);
                    
                    try
                    {
                        info.SetValue(o, obj);
                    }
                    catch { }

                }
                else
                {
                    info.SetValue(o, Data.Default.GetDefault(info));
                }
            }

            return o;
        }

        public List<T> Get(int qtd)
        {
            if (qtd <= 0)
                throw new Exceptions.ArgumentValueException($"The value of {nameof(qtd)}must be greater than zero");

            List<T> l = new List<T>();

            for (int i = 0; i < qtd; i++)
            {
                l.Add(Get());
            }

            return l;
        }
    }
}
