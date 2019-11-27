using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Aplicada2.Registros
{
	public partial class RegistroMaterial : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			LabelFecha.Text = DateTime.Now.Date.ToString("dd/MM/yy");		
			this.textboxId.ReadOnly = true;
			if (!IsPostBack)
			{
				System.Linq.Expressions.Expression<Func<Proveedor, bool>> filtro = x => true; ;
				Utilidades.LlenarDropDownList<Proveedor>(dropdownProveedor, new RepositorioBase<Proveedor>(), filtro, "ProveedorID", "Nombre");

				ViewState["data"] = new Materiales();
				int id = Request.QueryString["id"].ToInt();
				if (id > 0)
				{
					BLL.RepositorioBase<Materiales> repositorio = new BLL.RepositorioBase<Materiales>();
					Materiales data = repositorio.Buscar(id);
					if (data == null)
					{
						Utilidades.ShowToastr(this, "Materiales no encontrada!", "Advertencia", "warning");
						return;
					}

					LlenaCampos(data);
					Utilidades.ShowToastr(this, "Materiales Encontrada", "Exito!");
					textboxId.ReadOnly = true;
				}
			}
			else
			{
				Materiales data = (Materiales)ViewState["data"];
			}



		}

		public Materiales LlenaClase()
		{
			Materiales data = new Materiales();
			data.MaterialesID = textboxId.Text.ToInt();
			data.ProveedorID = dropdownProveedor.SelectedValue.ToInt();
			data.Nombre = textboxNombre.Text;
			data.Descripcion = textboxDescripcion.Text;
			data.Cantidad = textboxCantidad.Text.ToDecimal();
			data.Costo = textboxCosto.Text.ToDecimal();
			data.Fecha = DateTime.Now;

			return data;
		}

		public void LlenaCampos(Materiales data)
		{
			LabelFecha.Text = DateTime.Now.ToString();
			textboxNombre.Text = data.Nombre;
			textboxId.Text = data.MaterialesID.ToString();
			dropdownProveedor.SelectedValue = data.ProveedorID.ToString();
			textboxDescripcion.Text = data.Descripcion;
			textboxCantidad.Text = data.Cantidad.ToString();
			textboxCosto.Text = data.Costo.ToString();
		}

		protected void buttonBusqueda_Click(object sender, EventArgs e)
		{
			int id = textboxId.Text.ToInt();
			if (id == 0)
			{
				Utilidades.ShowToastr(this, "Debes ingresar los datos de busqueda correctamente", "Advertencia", "warning");
				return;
			}

			Materiales data = new BLL.RepositorioBase<Materiales>().Buscar(id);
			if (data == null)
			{
				Utilidades.ShowToastr(this, "No se encontro ninguna data con este id", "Advertencia", "warning");
				return;
			}

			LlenaCampos(data);
			Utilidades.ShowToastr(this, "Materiales Encontrada", "Exito!");
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
			Materiales data = LlenaClase();


			bool paso = true;
			if (data.MaterialesID > 0)
			{
				paso = new BLL.RepositorioBase<Materiales>().Modificar(data);
			}
			else
			{
				paso = new BLL.RepositorioBase<Materiales>().Guardar(data);
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

		private bool EsValido(Materiales usuario)
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
			BLL.RepositorioBase<Materiales> repositorio = new BLL.RepositorioBase<Materiales>();
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