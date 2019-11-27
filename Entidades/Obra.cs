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
    public class Obra
    {
        [Key]
        public int ObraID { get; set; }
        public int MaterialesID { get; set; }
        [ForeignKey("MaterialesID")]
        public virtual Materiales Materiales { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public decimal Presupuesto { get; set; }
        public decimal Itbis { get; set; }
        public decimal CostoEstimado { get; set; }
        public decimal CostoFinal { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal BeneficioEstimado { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Obra(int obraID, int materialesID, Materiales materiales, string nombre, string descripcion, string direccion, decimal presupuesto, decimal itbis, decimal costoEstimado, decimal costoFinal, decimal subTotal, decimal total, decimal beneficioEstimado, DateTime fechaIngreso)
        {
            ObraID = obraID;
            MaterialesID = materialesID;
            Materiales = materiales ?? throw new ArgumentNullException(nameof(materiales));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Presupuesto = presupuesto;
            Itbis = itbis;
            CostoEstimado = costoEstimado;
            CostoFinal = costoFinal;
            SubTotal = subTotal;
            Total = total;
            BeneficioEstimado = beneficioEstimado;
            FechaIngreso = fechaIngreso;
        }
    }
}
