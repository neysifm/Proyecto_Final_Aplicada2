<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroActividad.aspx.cs" Inherits="Proyecto_Final_Aplicada2.Registros.RegistroActividad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="container">
		<div class="row">
			<div class="col-lg-10 col-xl-9 mx-auto">
				<div class="card  flex-row my-5">
					<div class="card-img-left d-none d-md-flex">
					</div>
					<div class="card-body">
						<div class="card-header text-white h5" style="background-color: rgb(234, 82, 82)">
							<div class="card-title text-center text-uppercase">
								Registro de Actividad
								<asp:Label CssClass="float-right" runat="server" ID="LabelFecha" Text="11/12/2019"></asp:Label>
							</div>
						</div>

						<asp:Panel ID="formRegistro" runat="server">
							<hr />

							<div class="form-group">
								<div class="input-group">
									<asp:TextBox runat="server" type="number" ReadOnly="false" ID="textboxId" class="form-control" placeholder="ID" autofocus />
									<div class="input-group-append">
										<asp:Button runat="server" Text="Buscar" CssClass="btn btn-primary" formnovalidate OnClick="buttonBusqueda_Click" type="button" />
									</div>
								</div>

							</div>

							<div class="form-group">
								<label for="dropdownEmpleado">Empleado</label>
								<asp:DropDownList ID="dropdownEmpleado" runat="server"></asp:DropDownList>
							</div>

							<div class="form-group">
								<label for="textboxNombre">Nombre</label>
								<asp:TextBox runat="server" type="text" ID="textboxNombre" class="form-control" placeholder="Nombres" required />
							</div>

							<div class="row">
								<div class="col-6">
									<div class="form-group">
										<label for="textboxFechaInicio">Fecha Inicio</label>
										<asp:TextBox TextMode="Date" runat="server" type="text" ID="textboxFechaInicio" class="form-control required" />
									</div>
								</div>
								<div class="col-6">

									<div class="form-group">
										<label for="textboxFechaFin">Descripcion</label>
										<asp:TextBox TextMode="Date" runat="server" type="text" ID="textboxFechaFin" class="form-control" required />
									</div>

								</div>
							</div>
							<hr />

							<asp:Button Text="Nuevo" ID="NuevoButton" formnovalidate OnClick="NuevoButton_Click" runat="server" class="btn btn-lg btn-secondary text-uppercase" type="submit" />
							<asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" class="btn btn-lg btn-success text-uppercase" type="submit" />
							<asp:Button ID="EliminarButton" runat="server" formnovalidate OnClick="EliminarButton_Click" Text="Eliminar" class="btn btn-lg btn-danger text-uppercase" type="submit" />
							<a class="d-block text-center mt-2 small" href="#">Ver Listado</a>
							<hr class="my-4" />
						</asp:Panel>
					</div>

				</div>
			</div>
		</div>
	</div>
</asp:Content>
