namespace MyFaker.Data.Types
{
    public class Lorem
    {
        private Random _random;
        public Lorem()
        {
            _random = new Random();
            _data = _lorem.Split(' ');
        }

        public string Get()
        {
            return _data[_random.Next(0, _data.Length - 1)];
        }

        public string Get(int qtd)
        {
            string[] a = new string[qtd];

            for (int i = 0; i < qtd; i++)
            {
                a[i] = _data[_random.Next(0, _data.Length - 1)];
            }

            return String.Join(" ", a);
        }

        private string[] _data;

        private string _lorem = "Lorem Ipsum is simply dummy text of the printing and typesetting industry Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged it was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum";
    }
}
