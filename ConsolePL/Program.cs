using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Usuario");

            int opcion;
            Console.WriteLine("\n ¿Qué deseas realizar?");
            Console.WriteLine("\n 1. Vizualizar");
            Console.WriteLine("\n 2. Insertar");
            Console.WriteLine("\n 3. Actualizar");
            Console.WriteLine("\n 4. Eliminar");
            Console.WriteLine("\n 5. Carga masiva .txt");
            Console.WriteLine("\n 6. Carga masiva .Excel");

            opcion = int.Parse(Console.ReadLine());
            //int x;
            switch (opcion)
            {
                case 1:

                    //PL.Usuario.GetAll();

                    ConsolePL.Usuario.GetAll();

                    break;

                //case 2:

                //    PL.Usuario.GetAll();

                //    PL.Usuario.Add();

                //    break;

                //case 3:

                //    PL.Usuario.GetAll();

                //    PL.Usuario.Update();

                //    break;

                //case 4:

                //    PL.Usuario.GetAll();

                //    PL.Usuario.Delete();
                //    break;

                //case 5:

                //    PL.Empleado.FileTxt();
                //    break;
                //case 6:

                //    PL.Empleado.FileExel();

                //    break;

                default:
                    Console.WriteLine("\n No es una opcion validad");
                    break;

            }
            Console.ReadKey();
        }
    }
}
