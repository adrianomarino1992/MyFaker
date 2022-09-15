namespace MyFaker.Tests.Classes
{
    public class Person
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Email { get; set; }

        public virtual string Phone { get; set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual DateTime ModifiedAt { get; set; }
    }

    public class PersonModel : Person
    {        
        public override long Id { get; set; }
    }
}
