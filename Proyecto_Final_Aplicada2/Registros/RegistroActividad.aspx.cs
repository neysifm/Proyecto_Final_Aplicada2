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
	public partial class RegistroActividad : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			LabelFecha.Text = DateTime.Now.Date.ToString("dd/MM/yy");
			this.textboxId.ReadOnly = true;
			textboxFechaFin.Text = DateTime.Now.ToString();
			textboxFechaInicio.Text = DateTime.Now.ToString();	
			if (!IsPostBack)
			{
				System.Linq.Expressions.Expression<Func<Empleado, bool>> filtro = x => true; ;
				Utilidades.LlenarDropDownList<Empleado>(dropdownEmpleado, new RepositorioBase<Empleado>(), filtro, "EmpleadoID", "Nombre");

				ViewState["data"] = new Actividad();
				int id = Request.QueryString["id"].ToInt();
				if (id > 0)
				{
					BLL.RepositorioBase<Actividad> repositorio = new BLL.RepositorioBase<Actividad>();
					Actividad data = repositorio.Buscar(id);
					if (data == null)
					{
						Utilidades.ShowToastr(this, "Actividad no encontrada!", "Advertencia", "warning");
						return;
					}

					LlenaCampos(data);
					Utilidades.ShowToastr(this, "Actividad Encontrada", "Exito!");
					textboxId.ReadOnly = true;
				}
			}
			else
			{
				Actividad data = (Actividad)ViewState["data"];
			}



		}

		public Actividad LlenaClase()
		{
			Actividad data = new Actividad();
			data.ActividadID = textboxId.Text.ToInt();
			data.EmpleadoID = dropdownEmpleado.SelectedValue.ToInt();
			data.Nombre = textboxNombre.Text;
			data.Fecha_Fin = DateTime.Now;
			data.Fecha_Inicio = DateTime.Now;


			return data;
		}

		public void LlenaCampos(Actividad data)
		{
			LabelFecha.Text = DateTime.Now.ToString();
			textboxNombre.Text = data.Nombre;
			textboxId.Text = data.ActividadID.ToString();
			dropdownEmpleado.SelectedValue = data.EmpleadoID.ToString();
			textboxFechaFin.Text = data.Fecha_Fin.ToString();
			textboxFechaInicio.Text = data.Fecha_Inicio.ToString();
		}

		protected void buttonBusqueda_Click(object sender, EventArgs e)
		{
			int id = textboxId.Text.ToInt();
			if (id == 0)
			{
				Utilidades.ShowToastr(this, "Debes ingresar los datos de busqueda correctamente", "Advertencia", "warning");
				return;
			}

			Actividad data = new BLL.RepositorioBase<Actividad>().Buscar(id);
			if (data == null)
			{
				Utilidades.ShowToastr(this, "No se encontro ninguna data con este id", "Advertencia", "warning");
				return;
			}

			LlenaCampos(data);
			Utilidades.ShowToastr(this, "Actividad Encontrada", "Exito!");
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
			Actividad data = LlenaClase();


			bool paso = true;
			if (data.ActividadID > 0)
			{
				paso = new BLL.RepositorioBase<Actividad>().Modificar(data);
			}
			else
			{
				paso = new BLL.RepositorioBase<Actividad>().Guardar(data);
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

		private bool EsValido(Actividad usuario)
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
			BLL.RepositorioBase<Actividad> repositorio = new BLL.RepositorioBase<Actividad>();
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