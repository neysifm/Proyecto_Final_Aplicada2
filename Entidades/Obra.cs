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
		public virtual Materiales Materiales { get; set; }
        public virtual Actividad Actividades { get; set; }
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

        public Obra()
        {
            this.FechaIngreso = DateTime.Now;
            
        }
    }
}
