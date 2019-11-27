using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Actividad
    {
        [Key]
        public int ActividadID { get; set; }
        public int EmpleadoID { get; set; }
        [ForeignKey("EmpleadoID")]
        public virtual Empleado Empleados { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }

        public Actividad(int actividadID, int empleadoID, Empleado empleados, string nombre, DateTime fecha_Inicio, DateTime fecha_Fin)
        {
            ActividadID = actividadID;
            EmpleadoID = empleadoID;
            Empleados = empleados ?? throw new ArgumentNullException(nameof(empleados));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Fecha_Inicio = fecha_Inicio;
            Fecha_Fin = fecha_Fin;
        }

        public Actividad()
        {
            ActividadID = 0;
            EmpleadoID = 0;
            Nombre = String.Empty;
            Fecha_Inicio = DateTime.Now;
            Fecha_Fin = DateTime.Now;
        }
    }
}
