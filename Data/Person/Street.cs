namespace MyFaker.Data.Person
{
    public class Street
    {
        private Random _random;
        private Name _name;

        private readonly string[] _types = new string[]
        {
            "Av.",
            "Rua",
            "Estrada"
        };

        public Street()
        {
            _random = new Random();
            _name = new Name();
        }

        public string Get()
        {

            string n = _types[_random.Next(0, _types.Length - 1)];
            n += $" {_name.GetName()},";
            n += $" {_random.Next(1, 10000)}";

            return n;

        }

        public string[] Get(int qtd)
        {
            string[] s = new string[qtd];

            for (int i = 0; i < qtd; i++)
            {
                s[i] = Get();
            }

            return s;
        }


    }
}
