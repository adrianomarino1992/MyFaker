using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Data.Person
{
    public class Person
    {
        public string Name => new Name().GetName();
        public string CPF => new CPF().GetCPF();
    }
}
