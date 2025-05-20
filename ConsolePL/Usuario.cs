using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePL
{
    public class Usuario
    {
        public static void GetAll()
        {
            //ML.Result result = BL.Usuario.GetAll();
            //ML.Result result = BL.Usuario.GetAllSP();
            //ML.Result result = BL.Usuario.GetAllEF();
            ML.Result result = BL.Empleado.GetAllEF();

            if (result.Correct)
            {
                Console.WriteLine("IdEmpleado | Nombre | ApellidoPaterno | ApellidoMaterno | Edad | Direccion | Sexo | IdEmpres");
                foreach (ML.Empleado usuario in result.Objects)
                {

                    //Console.WriteLine(usuario.IdUsuario);
                    //Console.WriteLine(usuario.UserName);
                    //Console.WriteLine(usuario.Nombre);
                    //Console.WriteLine(usuario.ApellidoPaterno);
                    //Console.WriteLine(usuario.ApellidoMaterno);
                    //Console.WriteLine(usuario.Email);
                    //Console.WriteLine(usuario.Password);
                    //Console.WriteLine(usuario.Sexo);
                    //Console.WriteLine(usuario.Telefono);
                    //Console.WriteLine(usuario.Celular);
                    //Console.WriteLine(usuario.FechaNacimiento);
                    //Console.WriteLine(usuario.CURP);
                    //Console.WriteLine(usuario.Rol.IdRol);

                    // Console.WriteLine("\n");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"{usuario.IdEmpleado} | {usuario.Nombre}| {usuario.ApellidoPaterno} | {usuario.ApellidoMaterno} | {usuario.Edad} |{usuario.Dirrecion} | {usuario.Sexo} | {usuario.Empresa.IdEmpresa}");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
                }

            }
            else
            {

                Console.WriteLine("No se encontraron registros en la tabla Usuario " + result.ErrorMessage);

            }
        }
    }
}
