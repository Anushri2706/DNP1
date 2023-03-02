using System.Text.Json;

namespace Exercise1;

public class PersonPersistance
{
    public void StoreObjects(List<Person> persons)
    {
        using StreamWriter list = new StreamWriter("Person.txt");
        foreach (Person person in persons)
        {
            list.WriteLine(JsonSerializer.Serialize(person, new JsonSerializerOptions
            {
                WriteIndented = true
            }));
        }
    }
}