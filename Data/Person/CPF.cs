﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFaker.Data.Person
{
    public class CPF
    {
        private Random _random;

        public CPF()
        {
            _random = new Random();
        }
        public string GetCPF()
        {
            return GetCPFs(10)[_random.Next(0, 10)];
        }

        public List<string> GetCPFs(int qtd)
        {
            List<string> r = new List<string>();

            for (int i = 0; i < qtd; i++)
            {
                string cpf = _cpfs[_random.Next(0, _cpfs.Length - 1)];

                r.Add(cpf);

            }

            return r;
        }

        private string[] _cpfs = new string[]
        {
            "816.720.030-24",
            "743.412.371-01",
            "884.805.355-63",
            "813.626.014-11",
            "567.836.364-61",
            "711.605.881-80",
            "842.551.274-33",
            "832.807.241-63",
            "467.801.835-20",
            "621.553.816-70",
            "821.074.828-96",
            "083.601.606-86",
            "280.614.636-44",
            "108.611.518-01",
            "327.414.586-69",
            "253.223.776-70",
            "216.870.483-04",
            "587.827.170-28",
            "285.615.061-64",
            "071.181.461-96",
            "351.058.127-00",
            "230.201.028-04",
            "473.065.344-08",
            "167.353.647-67",
            "137.332.042-71",
            "381.328.055-18",
            "436.240.277-27",
            "187.016.147-54",
            "358.213.664-70",
            "387.234.302-57",
            "041.220.835-08",
            "837.830.071-43",
            "086.062.416-10",
            "145.467.280-34",
            "225.483.367-78",
            "217.427.761-16",
            "404.524.002-01",
            "675.274.782-25",
            "112.774.123-32",
            "560.202.705-05",
            "855.385.142-77",
            "845.508.872-90",
            "482.688.257-23",
            "653.764.730-40",
            "515.066.738-21",
            "803.443.168-07",
            "587.412.515-98",
            "804.463.771-04",
            "001.618.818-74",
            "835.573.660-57"
        };
    }
}
