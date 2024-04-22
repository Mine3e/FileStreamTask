using Newtonsoft.Json;

namespace JSONTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SerializeJSON();
            Console.WriteLine("----");
            DeserializeJSON();
        }
        public static void SerializeJSON()
        {
            Console.WriteLine("Name daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname daxil edin:");
            string surname = Console.ReadLine();

            string ageStr = "";
            int age;
            do
            {
                Console.WriteLine("Age daxil edin:");
                ageStr = Console.ReadLine();
            } while (!int.TryParse(ageStr, out age));
            Person person = new Person
            {
                Name = name,
                Surname = surname,
                Age = age
            };
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine(json);
        }
        public static void DeserializeJSON()
        {
            Console.WriteLine("JSON:");
            string json = Console.ReadLine();
            Person person = JsonConvert.DeserializeObject<Person>(json);
            Console.WriteLine($"Name:{person.Name},Surname :{person.Surname},Age:{person.Age}");
        }
    }
}
