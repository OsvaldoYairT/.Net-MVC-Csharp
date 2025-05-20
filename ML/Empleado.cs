using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ML
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public int? Edad { get; set; }

        public string Dirrecion { get; set; }
        public string Sexo { get; set; }
        public int? IdEmpresa { get; set; }

        public ML.Empresa Empresa { get; set; }

        public List<object> Empleados { get; set; }

    }
}
