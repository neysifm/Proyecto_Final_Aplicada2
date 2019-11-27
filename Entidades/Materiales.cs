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
    public class Materiales
    {
        [Key]
        public int MaterialesID { get; set; }
        public int ProveedorID { get; set; }
        [ForeignKey("ProveedorID")]
        public virtual Proveedor Proveedores { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public Materiales(int materialesID, int proveedorID, Proveedor proveedores, string nombre, string descripcion, DateTime fecha, decimal cantidad, decimal costo)
        {
            MaterialesID = materialesID;
            ProveedorID = proveedorID;
            Proveedores = proveedores ?? throw new ArgumentNullException(nameof(proveedores));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Fecha = fecha;
            Cantidad = cantidad;
            Costo = costo;
        }

        public Materiales()
        {
            MaterialesID = 0;
            ProveedorID = 0;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            Fecha = DateTime.Now;
            Cantidad = 0;
            Costo = 0;
        }
    }
}
