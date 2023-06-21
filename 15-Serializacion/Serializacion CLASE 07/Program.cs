//using System;
//using System.IO;
//using System.Xml.Serialization;

//namespace SerializationExample
//{
//    [Serializable]
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Crear un objeto de ejemplo
//            Person person = new Person
//            {
//                Name = "John Doe",
//                Age = 30
//            };

//            // Crear un XmlSerializer para serializar el objeto
//            XmlSerializer serializer = new XmlSerializer(typeof(Person));

//            // Crear un StreamWriter para guardar los datos serializados en un archivo XML
//            using (StreamWriter writer = new StreamWriter("person.xml"))
//            {
//                // Serializar el objeto en el StreamWriter
//                serializer.Serialize(writer, person);
//            }

//            Console.WriteLine("Objeto serializado y guardado en 'person.xml'.");

//            Console.ReadLine();
//        }
//    }
//}

using System;
using System.IO;
using System.Text.Json;

namespace SerializationExample
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de ejemplo
            Person person = new Person
            {
                Name = "John Doe",
                Age = 30
            };

            // Serializar el objeto a formato JSON
            string json = JsonSerializer.Serialize(person);

            //Console.WriteLine("cadena json {0}", json);

            // Guardar el JSON en un archivo
            File.WriteAllText("person.json", json);

            Console.WriteLine("Objeto serializado y guardado en 'person.json'.");

            Console.ReadLine();
        }
    }
}

