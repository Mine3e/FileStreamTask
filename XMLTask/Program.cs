using System.Xml.Serialization;
using System;
using System.IO.Pipes;

namespace XMLTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLSerialize();
            Console.WriteLine("---");
            DeserializeXML();
        }
        public static void XMLSerialize()
        {
            Console.WriteLine("Name daxil edin:");
            string name=Console.ReadLine();
            Console.WriteLine("Description daxil edin:");
            string desc=Console.ReadLine();
            Console.WriteLine("Category daxil edin:");
            string category=Console.ReadLine();
           
            string priceStr=string.Empty;
            int price;
            do
            {
                Console.WriteLine("Price daxil edin");
                priceStr = Console.ReadLine();
            }while(!int.TryParse(priceStr, out price));

            Product product = new Product
            {
                Name = name,
                Description = desc,
                Category = category,
                Price = price
            };
            XmlSerializer serializer = new XmlSerializer(typeof(Product));
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, product);
            string xml = stringWriter.ToString();
            Console.WriteLine(xml);
        }
        public static void DeserializeXML()
        {
            Console.WriteLine("XML:");
            string xml=Console.ReadLine();
            XmlSerializer serializer = new XmlSerializer(typeof(Product));
            StringReader stringReader = new StringReader(xml);
            Product product = (Product)serializer.Deserialize(stringReader);
            Console.WriteLine($"Name:{product.Name}, Description:{product.Description}, Category:{product.Category}, Price:{product.Price}"); ;
        }
    }
}
