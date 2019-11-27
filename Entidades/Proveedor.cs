using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Proveedor
    {
        [Key]
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Proveedor(int proveedorID, string nombre, string direccion, string telefono, string email)
        {
            ProveedorID = proveedorID;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public Proveedor()
        {
            ProveedorID = 0;
            Nombre = String.Empty;
            Direccion = String.Empty;
            Telefono = String.Empty;
            Email = String.Empty;
        }
    }
}
