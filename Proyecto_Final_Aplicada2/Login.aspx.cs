using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Aplicada2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonRegitrarse_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            } else
            {
                Usuario usuario = LlenaClaseRegistro();
                bool paso = new BLL.RepositorioBase<Usuario>().Guardar(usuario);
                if(paso)
                {
                    Utilidades.ShowToastr(this, "Registro completado de manera exitosa!", "Exito!", "success");
                    return;
                } else
                {
                    Utilidades.ShowToastr(this, "Error al intentar guardar!", "Error", "error");
                    return;
                }
                
            }
           
           
        }

        private bool Validar()
        {
            if (textboxpassr.Text != textboxrepeatpassr.Text) {
                Utilidades.ShowToastr(this, "Debe llenar los campos de manera correcta", "Error", "error");
                return false;
            }
                
            if (new BLL.RepositorioBase<Usuario>().GetList(x=>x.Email == textboxemailr.Text).Count > 0)
            {
                Utilidades.ShowToastr(this, "Este correo ya ha sido registrado!", "Error", "error");
                return false;
            }

            return true;
        }

        private Usuario LlenaClaseRegistro()
        {
            return new Usuario()
            {
                Nombre = textboxNombre.Text,                
                Email = textboxemailr.Text,
                Clave = Utilidades.Hash(textboxpassr.Text)
            };
        }

        protected void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = LlenaClaseLogin();
            List<Usuario> lista = new BLL.RepositorioBase<Usuario>().GetList(x=>true);
            if (new BLL.RepositorioBase<Usuario>().GetList(x=>x.Email == usuario.Email && x.Clave == usuario.Clave).Count > 0)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                Utilidades.ShowToastr(this, "Credenciales invalidas!", "Error", "error");
            }
        }

        private Usuario LlenaClaseLogin()
        {
            return new Usuario()
            {
                Email = textboxemaillogin.Text,
                Clave = Utilidades.Hash(textboxpasswordlogin.Text)
            };
        }
    }
}