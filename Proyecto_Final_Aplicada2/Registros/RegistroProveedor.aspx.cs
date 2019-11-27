using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Aplicada2.Registros
{
    public partial class RegistroProveedor : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
			LabelFecha.Text = DateTime.Now.Date.ToString("dd/MM/yy");
			this.textboxId.ReadOnly = true;
			if (!IsPostBack)
			{

				ViewState["data"] = new Proveedor();
				int id = Request.QueryString["id"].ToInt();
				if (id > 0)
				{
					BLL.RepositorioBase<Proveedor> repositorio = new BLL.RepositorioBase<Proveedor>();
					Proveedor data = repositorio.Buscar(id);
					if (data == null)
					{
						Utilidades.ShowToastr(this, "Proveedor no encontrada!", "Advertencia", "warning");
						return;
					}

					LlenaCampos(data);
					Utilidades.ShowToastr(this, "Proveedor Encontrada", "Exito!");
					textboxId.ReadOnly = true;
				}
			}
			else
			{
				Proveedor data = (Proveedor)ViewState["data"];
			}



		}

		public Proveedor LlenaClase()
		{
			Proveedor data = new Proveedor();
			data.ProveedorID = textboxId.Text.ToInt();
			data.Nombre = textboxNombre.Text;
			data.Email = textboxEmail.Text;
			data.Telefono = textboxTelefono.Text;
			data.Direccion = textboxDireccion.Text;

			return data;
		}

		public void LlenaCampos(Proveedor data)
		{
			LabelFecha.Text = DateTime.Now.ToString();
			textboxNombre.Text = data.Nombre;
			textboxId.Text = data.ProveedorID.ToString();
			textboxTelefono.Text = data.Telefono;
			textboxEmail.Text = data.Email;
			textboxDireccion.Text = data.Direccion;
		}

		protected void buttonBusqueda_Click(object sender, EventArgs e)
		{
			int id = textboxId.Text.ToInt();
			if (id == 0)
			{
				Utilidades.ShowToastr(this, "Debes ingresar los datos de busqueda correctamente", "Advertencia", "warning");
				return;
			}

			Proveedor data = new BLL.RepositorioBase<Proveedor>().Buscar(id);
			if (data == null)
			{
				Utilidades.ShowToastr(this, "No se encontro ninguna data con este id", "Advertencia", "warning");
				return;
			}

			LlenaCampos(data);
			Utilidades.ShowToastr(this, "Proveedor Encontrada", "Exito!");
			textboxId.ReadOnly = true;
			return;

		}

		protected void NuevoButton_Click(object sender, EventArgs e)
		{
			Utilidades.ClearControls(formRegistro, new List<Type>() { typeof(TextBox) });
			textboxId.ReadOnly = false;
		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{
			Proveedor data = LlenaClase();


			bool paso = true;
			if (data.ProveedorID > 0)
			{
				paso = new BLL.RepositorioBase<Proveedor>().Modificar(data);
			}
			else
			{
				paso = new BLL.RepositorioBase<Proveedor>().Guardar(data);
			}
			if (!paso)
			{
				Utilidades.ShowToastr(this, "Error al intentar guardar la data!", "Error", "error");
				return;
			}

			Utilidades.ShowToastr(this, "Registro Guardado Correctamete!", "Exito", "success");
			Utilidades.ClearControls(formRegistro, new List<Type>() { typeof(TextBox) });
			return;
		}

		private bool EsValido(Proveedor usuario)
		{

			return true;
		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{
			int id = textboxId.Text.ToInt();
			if (id < 0)
			{
				Utilidades.ShowToastr(this, "Id invalido", "Advertencia", "warning");
				return;
			}
			BLL.RepositorioBase<Proveedor> repositorio = new BLL.RepositorioBase<Proveedor>();
			if (repositorio.Buscar(id) == null)
			{
				Utilidades.ShowToastr(this, "Registro no encontrado", "Advertencia", "warning");
				return;
			}

			bool paso = repositorio.Eliminar(id);
			if (!paso)
			{
				Utilidades.ShowToastr(this, "Error al intentar eliminar el registro", "Error", "error");
				return;
			}

			Utilidades.ShowToastr(this, "Registro eliminado correctamente!", "exito", "success");
			return;
		}
	}
}