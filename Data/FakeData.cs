namespace MyFaker.Data
{
    public class FakeData
    {        
        public MyFaker.Data.Person.Person Person { get; }
        public MyFaker.Data.Types.Number Number { get; }
        public MyFaker.Data.Types.Lorem Lorem { get; }

        public FakeData()
        {
            Person = new Person.Person();
            Number = new Types.Number();
            Lorem = new Types.Lorem();
        }
    }
}
