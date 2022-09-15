using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Data.Person
{
    public class Person
    {
        private string _name;
        public string Name
        {

            get
            {
                if(String.IsNullOrEmpty(_name))
                {
                    _name = new Name().GetName();
                }

                return _name.Split(' ')[0].Trim();
            }

        }

        public string LastName 
        {
            get
            {
                if (String.IsNullOrEmpty(_name))
                {
                    _name = new Name().GetName();
                }

                string[] _arr = _name.Split(' ');

                return String.Join(' ', _arr.Length > 2 ? _arr.TakeLast(2) : _arr.TakeLast(1)).Trim();
            }
        }

        public string FullName => $"{Name} {LastName}";

        private string _cpf;
        public string CPF 
        {
            get
            {
                if (String.IsNullOrEmpty(_name))
                {
                    _cpf = new CPF().GetCPF();
                }

                return _cpf;
            }
        }
    }
}
