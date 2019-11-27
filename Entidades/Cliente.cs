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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }     


        public Cliente()
        {
            ClienteID = 0;
            UsuarioID = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
            Telefono = String.Empty;
            Direccion = String.Empty;
        }
    }
}
