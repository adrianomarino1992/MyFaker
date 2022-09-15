using MyFaker.Tests.Classes;


namespace MyFaker.Tests
{
    public class TestAllMethods
    {
        MyFaker.Objects.Faker<PersonModel> _faker;
        public TestAllMethods()
        {
            _faker = new PersonFaker();
        }


        [Fact]
        public void Create()
        {
            Person control = _faker.Get();

            Assert.Equal(0, control.Id);

        }


        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(50)]
        public void CreateMany(int qtd)
        {
            List<PersonModel> persons = _faker.Get(qtd);

            Assert.Equal(qtd, persons.Count);
        }
    }
}