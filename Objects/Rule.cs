using MyFaker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Objects
{
    public class Rule
    {
        public PropertyInfo Property { get; }

        public Func<FakeData, object> GetValue { get; set; }


        public Rule(PropertyInfo prop, Func<FakeData, object> func)
        {
            Property = prop;
            GetValue = func;
        }

        public object? Run() => GetValue?.Invoke(Data.FakeData.Instance);
    }
}
