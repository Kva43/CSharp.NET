using System;

//namespace Vista_Archivos
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("OSVersion: {0}", Environment.OSVersion);
//            Console.WriteLine("OSVersion.Platform: {0}", Environment.OSVersion.Platform);
//            Console.WriteLine("OSVersion.Version: {0}", Environment.OSVersion.Version);
//        }
//    }
//}

using System.IO;
using System;

namespace Vista_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, -26} | {4, -26} |",
            "Nombre", "Tipo", "Formato", "Tamaño", "Espacio libre");

            foreach (DriveInfo unidad in DriveInfo.GetDrives())
            {
                if (unidad.IsReady)
                {
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, 20:N0} bytes | {4, 20:N0} bytes |",
                    unidad.Name, unidad.DriveType, unidad.DriveFormat, unidad.TotalSize, unidad.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0, -10} | {1, -10}", unidad.Name, unidad.DriveType);
                }
            }
        }
    }
}