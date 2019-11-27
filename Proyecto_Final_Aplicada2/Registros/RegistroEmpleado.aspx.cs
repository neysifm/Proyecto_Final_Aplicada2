using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Aplicada2.Registros
{
    public partial class RegistroEmpleado : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
			LabelFecha.Text = DateTime.Now.Date.ToString("dd/MM/yy");
			this.textboxId.ReadOnly = true;
			if (!IsPostBack)
			{

				ViewState["data"] = new Empleado();
				int id = Request.QueryString["id"].ToInt();
				if (id > 0)
				{
					BLL.RepositorioBase<Empleado> repositorio = new BLL.RepositorioBase<Empleado>();
					Empleado data = repositorio.Buscar(id);
					if (data == null)
					{
						Utilidades.ShowToastr(this, "Empleado no encontrada!", "Advertencia", "warning");
						return;
					}

					LlenaCampos(data);
					Utilidades.ShowToastr(this, "Empleado Encontrada", "Exito!");
					textboxId.ReadOnly = true;
				}
			}
			else
			{
				Empleado data = (Empleado)ViewState["data"];
			}



		}

		public Empleado LlenaClase()
		{
			Empleado data = new Empleado();
			data.EmpleadoID = textboxId.Text.ToInt();
			data.Nombre = textboxNombre.Text;
			data.Departamento = textboxDepartamento.Text;
			data.Telefono = textboxTelefono.Text;
			data.Cargo = textboxCargo.Text;

			return data;
		}

		public void LlenaCampos(Empleado data)
		{
			LabelFecha.Text = DateTime.Now.ToString();
			textboxNombre.Text = data.Nombre;
			textboxId.Text = data.EmpleadoID.ToString();
			textboxTelefono.Text = data.Telefono;
			textboxCargo.Text = data.Cargo;
			textboxDepartamento.Text = data.Departamento;
		}

		protected void buttonBusqueda_Click(object sender, EventArgs e)
		{
			int id = textboxId.Text.ToInt();
			if (id == 0)
			{
				Utilidades.ShowToastr(this, "Debes ingresar los datos de busqueda correctamente", "Advertencia", "warning");
				return;
			}

			Empleado data = new BLL.RepositorioBase<Empleado>().Buscar(id);
			if (data == null)
			{
				Utilidades.ShowToastr(this, "No se encontro ninguna data con este id", "Advertencia", "warning");
				return;
			}

			LlenaCampos(data);
			Utilidades.ShowToastr(this, "Empleado Encontrada", "Exito!");
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
			Empleado data = LlenaClase();


			bool paso = true;
			if (data.EmpleadoID > 0)
			{
				paso = new BLL.RepositorioBase<Empleado>().Modificar(data);
			}
			else
			{
				paso = new BLL.RepositorioBase<Empleado>().Guardar(data);
			}
			if (!paso)
			{
				Utilidades.ShowToastr(this, "Error al intentar guardar la data!", "Error", "error");
				return;
			}

			Utilidades.ShowToastr(this, "Registro Guardado Correctamete!", "Exito", "success");
			return;
		}

		private bool EsValido(Empleado usuario)
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
			BLL.RepositorioBase<Empleado> repositorio = new BLL.RepositorioBase<Empleado>();
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