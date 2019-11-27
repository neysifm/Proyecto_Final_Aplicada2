using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public Usuario(int usuarioID, string nombre, string email, string clave)
        {
            UsuarioID = usuarioID;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Clave = clave ?? throw new ArgumentNullException(nameof(clave));
        }

        public Usuario()
        {
            UsuarioID = 0;
            Nombre = String.Empty;
            Email = String.Empty;
            Clave = String.Empty;
        }
    }
}
