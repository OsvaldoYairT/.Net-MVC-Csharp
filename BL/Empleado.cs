using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML;

namespace BL
{
    public class Empleado
    {

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.PruebasEntities context = new DL.PruebasEntities())
                {
                    var resultQuery = context.EmpleadoGetAll().ToList();


                    if (resultQuery != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in resultQuery)
                        {
                            ML.Empleado empleado = new ML.Empleado();
                            empleado.IdEmpleado = obj.IdEmpleado;
                            empleado.Nombre = obj.Nombre;
                            empleado.ApellidoPaterno = obj.ApellidoPaterno;
                            empleado.ApellidoMaterno = obj.ApellidoMaterno;
                            empleado.Edad = obj.Edad;
                            empleado.Dirrecion = obj.Dirección;
                            empleado.Sexo = obj.Sexo;
                            empleado.Empresa = new ML.Empresa();
                            empleado.Empresa.IdEmpresa = obj.IdEmpresa;
                           empleado.Empresa.Nombre = obj.Empresa;

                            result.Objects.Add(empleado);
                            result.Correct = true;

                        }
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error la tabla no contiene informacion correcta";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetByIdUsuario(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.PruebasEntities context = new DL.PruebasEntities())
                {
                    var resultQuery = context.EmpleadoGetById(IdUsuario).FirstOrDefault();

                    result.Objects = new List<object>();

                    if (resultQuery != null)
                    {
                        ML.Empleado empleado = new ML.Empleado();
                        empleado.IdEmpleado = resultQuery.IdEmpleado;
                        empleado.Nombre = resultQuery.Nombre;
                        empleado.ApellidoPaterno = resultQuery.ApellidoPaterno;
                        empleado.ApellidoMaterno = resultQuery.ApellidoMaterno;
                        empleado.Edad = resultQuery.Edad;
                        empleado.Dirrecion = resultQuery.Dirección;
                        empleado.Sexo = resultQuery.Sexo;
                        empleado.Empresa = new ML.Empresa();
                        empleado.Empresa.IdEmpresa = resultQuery.IdEmpresa;
                        empleado.Empresa.Nombre = resultQuery.Nombre;

                        result.Object = empleado;
                        result.Correct = true;


                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Hubo un error en buscar el nombre del empleado";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.ToString();
            }

            return result;
        }
    }
}
