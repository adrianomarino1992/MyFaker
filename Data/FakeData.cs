namespace MyFaker.Data
{
    public class FakeData
    {
        private static FakeData? _instance;
        public static FakeData Instance => _instance ?? (_instance = new FakeData());
        public MyFaker.Data.Person.Person Person { get; }
        public MyFaker.Data.Types.Number Number { get; }
        public MyFaker.Data.Types.Lorem Lorem { get; }

        private FakeData()
        {
            Person = new Person.Person();
            Number = new Types.Number();
            Lorem = new Types.Lorem();
        }
    }
}
