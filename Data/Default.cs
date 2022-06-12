using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace MyFaker.Data
{
    public static class Default
    {
        private static Random _random;

        static Default()
        {
            _random = new Random();
        }


        public static object GetDefault(Type type)
        {

            if (type.IsAssignableTo(typeof(Array)) && type.GetElementType() != null && type != typeof(string))
            {
                int l = _random.Next(1, 10);

#pragma warning disable
                Array ar = Array.CreateInstance(type.GetElementType(), l);
#pragma warning enable

                for (int i = 0; i < l; i++)
                {
                    ar.SetValue(GetDefault(type), i);
                }

                return ar;
            }

            if (type.IsAssignableTo(typeof(IList)) && type.GetGenericArguments().Count() > 0 && type != typeof(string))
            {
                int l = _random.Next(1, 10);

#pragma warning disable
                ConstructorInfo? ctor = type.GetConstructor(new Type[] { });
#pragma warning enable

                if (ctor is null)
                    throw new Exceptions.ContructorNotFoundException(type);

                IList? ls = (IList)ctor?.Invoke(new object[] { });

                for (int i = 0; i < l; i++)
                {
                    ls.Add(GetDefault(type));
                }

                return ls;
            }

            if(type.IsClass && type != typeof(string))
            {
                ConstructorInfo? ctor = type.GetConstructor(new Type[] { });

                if (ctor is null)
                    throw new Exceptions.ContructorNotFoundException(type);


                object o = ctor.Invoke(new object[] { });

                foreach(PropertyInfo info in MyRefs.Extensions.ReflectionExtension.GetPublicProperties(type, s => true))
                {
                    if (info.SetMethod != null)
                        info.SetValue(o, GetDefault(info));
                }

                return o;
            }


            if (type == typeof(string))
            {
                return $"Default value of a String";
            }

            if (type == typeof(Int32))
                return _random.Next(0, int.MaxValue);

            if (type == typeof(long))
                return _random.Next(0, int.MaxValue);

            if (type == typeof(double))
                return _random.NextDouble() * 10;

            if (type == typeof(float))
                return _random.NextDouble() * 10;

            if (type == typeof(DateTime))
                return new DateTime(_random.Next(1992, DateTime.Now.Year), _random.Next(1, 12), _random.Next(1, 28));

            if (type == typeof(bool))
                return _random.Next(0, 1) == 1;

            /*
             * add validations
             */
            if (type.IsEnum)
            {
                Array values = Enum.GetValues(type);

                int[] pos = new int[values.Length];

                int p = 0;

                foreach (object o in values)
                {
                    pos[p] = (int)o;
                }

                return pos[_random.Next(0, pos.Length - 1)];

            }

            return new object();

        }

        public static object GetDefault(PropertyInfo info)
        {
            Type f = info.PropertyType;           

            if(f == typeof(string))
            {
                return $"Default value of {info.Name}";
            }

            return GetDefault(info.PropertyType);

        }
    }
}
