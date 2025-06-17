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

            var deserialized = JsonSerializer.Deserialize<People>(json);

            if (deserialized == null) // Ensure the deserialization result is not null.
            {
                throw new InvalidOperationException("Deserialization resulted in a null object.");
            }

            return deserialized;
        }
    }
}
