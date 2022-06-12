namespace MyFaker.Data.Types
{
    public class Number
    {
        private Random _random;
        public Number()
        {
            _random = new Random();
        }

        public object GetPositive(int decimals = 0)
        {
            if (decimals == 0)
                return _random.Next(0, int.MaxValue);

            return Math.Round(_random.NextDouble() * 10, decimals);
        }

        public object GetNegative(int decimals = 0)
        {
            if (decimals == 0)
                return _random.Next(int.MinValue, -1);

            return Math.Round(_random.NextDouble() * -10, decimals);
        }

        public object Get(int decimals = 0)
        {
            if (decimals == 0)
                return _random.Next(int.MinValue, int.MaxValue);

            return Math.Round(_random.NextDouble() * 10, decimals);
        }
    }
}
