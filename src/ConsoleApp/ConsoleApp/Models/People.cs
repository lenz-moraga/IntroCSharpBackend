using System.Text.Json;

namespace ConsoleApp.Models
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string ToJson()
        {
            return JsonSerializer.Serialize(this); // This method serializes the current instance of People to a JSON string.
        }
        public static People FromJson(string json)
        {
            return JsonSerializer.Deserialize<People>(json);
        }
    }
}
