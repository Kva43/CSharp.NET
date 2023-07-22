using System;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\crist\\OneDrive\\Escritorio\\MOCK_DATA.json";

            using (StreamReader reader = new StreamReader(path))
            {
                string contenido = reader.ReadToEnd();
                Console.WriteLine(contenido);
            }
        }
    }
}