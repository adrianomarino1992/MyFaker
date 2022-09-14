# MyFaker

MyFaker allow us to generate fake objects based on rules.


## Installation

.NET CLI

```bash
dotnet add package Adr.MyFaker  --version 1.1.0
```

Nuget package manager

```bash
PM> Install-Package Adr.MyFaker -Version 1.1.0
```

packageReference

```bash
<PackageReference Include="Adr.MyFaker " Version="1.1.0" />
```

## Usage

**With this sample classes:**
```csharp
         public class User
            {                
                public long Id { get; set; }
                public int Age { get; set; }
                public String Name { get; set; }
                public String Document { get; set; }            
                public User() { }
            }


```


**We can create a faker provider**
```csharp
public class FakerUser : Faker<User>
    {
        public FakerUser()
        {
            AddRule(s => s.Id, o => o.Number.GetPositive());
            AddRule(s => s.Age, o => o.Number.GetPositive(18,50));
            AddRule(s => s.Name, o => o.Person.Name);
            AddRule(s => s.Document, o => o.Person.CPF);
        }
    }

```

**We can add before and after delegates to all methods in a object:**
```csharp
           
           List<User> fakeUsers = new FakerUser().Get(10) // will create 10 instances of User

```



## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
