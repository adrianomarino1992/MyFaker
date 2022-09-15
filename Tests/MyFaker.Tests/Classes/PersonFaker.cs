using MyFaker.Objects;

namespace MyFaker.Tests.Classes
{
    public class PersonFaker : Faker<PersonModel>
    {
        public PersonFaker()
        {
            AddRule(s => s.CreatedAt, faker => DateTime.Now);
            AddRule(s => s.ModifiedAt, faker => DateTime.Now);
            AddRule(s => s.Name, faker => faker.Person.FullName);
            AddRule(s => s.Email, faker => faker.Person.Name + "@email.com");            
            AddRule(s => s.Id, faker => 0);
            
        }

    }
}
