using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Empleado
    {
        [Key]
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }

        public Empleado()
        {
            EmpleadoID = 0;
            Nombre = String.Empty;
            Telefono = String.Empty;
            Departamento = String.Empty;
            Cargo = String.Empty;
     
        }
        
    }
}
