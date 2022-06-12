using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Interfaces
{
    public interface IFaker<T> where T : class
    {
        T Get();

        List<T> Get(int qtd);
    }
}
