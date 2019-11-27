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
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuario Usuarios { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public decimal Descuento { get; set; }
        public string MetodoDePago { get; set; }

        public Cliente(int clienteID, int usuarioID, Usuario usuarios, string nombre, string apellido, string telefono, string direccion, decimal descuento, string metodoDePago)
        {
            ClienteID = clienteID;
            UsuarioID = usuarioID;
            Usuarios = usuarios ?? throw new ArgumentNullException(nameof(usuarios));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Descuento = descuento;
            MetodoDePago = metodoDePago ?? throw new ArgumentNullException(nameof(metodoDePago));
        }

        public Cliente()
        {
            ClienteID = 0;
            UsuarioID = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
            Telefono = String.Empty;
            Direccion = String.Empty;
            Descuento = 0;
            MetodoDePago = String.Empty;
        }
    }
}
