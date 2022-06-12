using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Data.Person
{
    public class Name
    {
        private Random _random;

        public Name()
        {
            _random = new Random();
        }
        public string GetName()
        {
           return GetNames(10)[_random.Next(0, 10)];
        }

        public List<string> GetNames(int qtd)
        {
            List<string> r = new List<string>();

            for (int i = 0; i < qtd; i++)
            {
                string name = _names[_random.Next(0, _names.Length - 1)];

                name += $" {_lastNames[_random.Next(0, _lastNames.Length - 1)]}";

                if(i % 2 == 0)
                    name += $" {_lastNames[_random.Next(0, _lastNames.Length - 1)]}";

                r.Add(name);

            }

            return r;
        }

        private string[] _names = new string[] {
            "Adriano",
            "Brenda",
            "Ana",
            "Gabriela",
            "Sophie",
            "Laura",
            "Manuela",
            "Cecília",
            "Calebe",
            "Sophie",
            "Rodrigo",
            "Ian",
            "Lucas",
            "Sophie",
            "Emilly",
            "Ana",
            "Júlia",            
            "Juan",
            "Bryan",           
            "Marcelo",
            "Breno",           
            "Benjamin",
            "Mariane",
            "Arthur",
            "Laura",
            "Vicente",
            "Luiz",
            "Pedro",
            "Rafael",
            "Sophia",
            "Laís",           
            "Isadora",
            "Luiz",            
            "Alexia",
            "Luna",
            "Nicolas",
            "Mariane",
            "Bryan",
            "Gustavo",
            "Vitória",
            "Ana",            
            "André",
            "Alexia"
        };

        private string[] _lastNames = new string[] {
            "Marino",
            "Balera",
            "Ramos",
            "Luiza",
            "Moreira",
            "Farias",
            "Lima",
            "Ribeiro",
            "Azevedo",
            "Mata",
            "Rocha",
            "Moreira",
            "Azevedo",
            "Vieira",
            "Mirella",
            "Otávio",
            "Gomes",
            "Duarte",
            "Carolina",
            "Cruz",
            "Kaique",
            "Cardoso",
            "Araújo",
            "Juliana",
            "Alves",
            "Jesus",
            "Isadora",
            "Dias",
            "Cruz",
            "Pereira",
            "Conceição",
            "Fernando",
            "Henrique",
            "Sales",
            "Fernandes",
            "Rocha",
            "Isadora",
            "Moreira",
            "Henrique",
            "Cauã",
            "Aragão",
            "Vieira",
            "Lopes",
            "Costa",
            "Duarte",
            "Henrique",
            "Luz",
            "Beatriz",
            "Vitor",
            "Pires",
            "Souza"

        };
    }
}
