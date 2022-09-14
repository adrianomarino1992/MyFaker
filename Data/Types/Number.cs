namespace MyFaker.Data.Types
{
    public class Number
    {
        private Random _random;
        public Number()
        {
            _random = new Random();
        }

        public object GetNextInt(int min = 0 , int max = int.MaxValue)
        {
            return _random.Next(min, max);
        }

        public object GetPositive(int min = 0, int max = int.MaxValue, int decimals = 0)
        {
            if (decimals == 0)
                return _random.Next(min, max);

            return Math.Round(_random.Next(min, (int)(max / 1.13)) * 1.12, decimals);
        }

        public object GetNegative(int min = 0, int max = int.MaxValue, int decimals = 0)
        {
            if (decimals == 0)
                return _random.Next(min, max);

            return Math.Round(_random.Next(min, (int)(max / 1.13)) * -1.12, decimals);
        }

        public object Get(int decimals = 0)
        {
            if (decimals == 0)
                return _random.Next(int.MinValue, int.MaxValue);

            return Math.Round(_random.NextDouble() * 10, decimals);
        }
    }
}
