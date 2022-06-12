using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Exceptions
{

    public class MyFakerExecption : Exception
    {
        public override string Message { get; }

#pragma warning disable
        public MyFakerExecption ()
        {
            
        }
        public MyFakerExecption(string msg) : base(msg)
        {

        }
#pragma warning enable
    }

    public class PropertyNotFoundException : MyFakerExecption
    {
        public string Property { get; }
        public Type Type { get; }
        public override string Message { get; }
        public PropertyNotFoundException(Type type, string prop, string msg = "")
        {

            Message = msg;

            if (String.IsNullOrEmpty(msg))
            {
                Message = $"The type {type.Name} do not have any public property named {prop}";
            }

            Property = prop;
            Type = type;

        }
    }


    public class ContructorNotFoundException : MyFakerExecption
    {       
        public Type Type { get; }
        public override string Message { get; }
        public ContructorNotFoundException(Type type,string msg = "")
        {
            Message = msg;

            if (String.IsNullOrEmpty(msg))
            {
                Message = $"The parameterless contructor of type {type.Name} was not found";
            }
            
            Type = type;

        }
    }

    public class InvalidCastException : MyFakerExecption
    {       
        public override string Message { get; }
        public InvalidCastException(string msg)
        {
            Message = msg;                       
        }
    }
    public class RuleAlreadyExistsException : MyFakerExecption
    {
        public MyFaker.Objects.Rule Rule { get; }
        public override string Message { get; }
        public RuleAlreadyExistsException(MyFaker.Objects.Rule rule, string msg = "")
        {
            Message = msg;

            if (String.IsNullOrEmpty(msg))
            {
                Message = $"The rule of {rule.Property.Name} already exists";
            }

            Rule = rule;
        }
    }

    public class ArgumentValueException : MyFakerExecption
    {
        public override string Message { get; }
        public ArgumentValueException(string msg)
        {
            Message = msg;
        }
    }
}
