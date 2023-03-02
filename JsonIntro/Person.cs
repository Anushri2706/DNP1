using System.Text.Json;

namespace Exercise1;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Height { get; set;  }
    public Boolean IsMarried { get; set; }
    public char Sex { get; set; }
    public string[] Hobbies { get; set; }
    
    static void Main(string[] args)
    {
        
        Person obj1 = new Person()
        {
            FirstName = "Anushri",
            LastName = "Gupta",
            Age = 19,
            Height = 167,
            IsMarried = false,
            Sex = 'F',
            Hobbies = new string[]{"Reading", "Sleeping"}
        };
        
        Person obj2 = new Person()
        {
            FirstName = "Hello",
            LastName = "Gupta",
            Age = 49,
            Height = 117,
            IsMarried = false,
            Sex = 'F',
            Hobbies = new string[]{"Reading", "Sleeping"}
        };
        
        Person obj3 = new Person()
        {
            FirstName = "Hi",
            LastName = "Gupta",
            Age = 119,
            Height = 367,
            IsMarried = false,
            Sex = 'F',
            Hobbies = new string[]{"Reading", "Sleeping"}
        };
        
        
        string jsonObj = JsonSerializer.Serialize(obj1, new JsonSerializerOptions{
            WriteIndented = true});
        
        string jsonObj1 = JsonSerializer.Serialize(obj2, new JsonSerializerOptions{
            WriteIndented = true});
        
        string jsonObj2 = JsonSerializer.Serialize(obj3, new JsonSerializerOptions{
            WriteIndented = true});
        
        Console.WriteLine(jsonObj);
        List<Person> persons = new List<Person>();
        persons.Add(obj1);
        persons.Add(obj2);
        persons.Add(obj3);
        
        PersonPersistance persistence = new PersonPersistance();
        persistence.StoreObjects(persons);
    }
}
