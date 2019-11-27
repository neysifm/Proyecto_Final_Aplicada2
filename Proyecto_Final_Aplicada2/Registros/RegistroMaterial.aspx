<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroMaterial.aspx.cs" Inherits="Proyecto_Final_Aplicada2.Registros.RegistroMaterial" %>

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
								Registro de Materiales
								<asp:Label CssClass="float-right" runat="server" ID="LabelFecha" Text="11/12/2019"></asp:Label>
							</div>
						</div>

						<asp:Panel ID="formRegistro" runat="server">
							<hr />
							<div class="form-group">
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
									<asp:DropDownList ID="dropdownProveedor" runat="server"></asp:DropDownList>								
								</div>

								<div class="form-group">
									<label for="textboxNombre">Nombre</label>
									<asp:TextBox runat="server" type="text" ID="textboxNombre" class="form-control" placeholder="Nombres" required />
								</div>

								<div class="form-group">
									<label for="textboxDescripcion">Descripcion</label>
									<asp:TextBox runat="server" type="text" ID="textboxDescripcion" class="form-control" placeholder="Descripcion" required />
								</div>

								<div class="form-group">
									<label for="textboxCantidad">Cantidad</label>
									<asp:TextBox runat="server" type="number" ID="textboxCantidad" class="form-control" placeholder="Cantidad" required />
								</div>

								<div class="form-group">
									<label for="textboxCosto">Costo</label>
									<asp:TextBox runat="server" type="number" ID="textboxCosto" class="form-control" placeholder="Costo" required />
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
