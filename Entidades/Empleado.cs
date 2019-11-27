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
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public decimal Costo_Por_Hora { get; set; }
        public decimal Sueldo { get; set; }

        public Empleado(int empleadoID, string nombre, string telefono, string direccion, string email, string departamento, string cargo, decimal costo_Por_Hora, decimal sueldo)
        {
            EmpleadoID = empleadoID;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Departamento = departamento ?? throw new ArgumentNullException(nameof(departamento));
            Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
            Costo_Por_Hora = costo_Por_Hora;
            Sueldo = sueldo;
        }

        public Empleado()
        {
            EmpleadoID = 0;
            Nombre = String.Empty;
            Telefono = String.Empty;
            Direccion = String.Empty;
            Email = String.Empty;
            Departamento = String.Empty;
            Cargo = String.Empty;
            Costo_Por_Hora = 0;
            Sueldo = 0;
        }
        
    }
}
