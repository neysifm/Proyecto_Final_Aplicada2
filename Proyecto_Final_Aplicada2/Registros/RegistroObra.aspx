<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroObra.aspx.cs" Inherits="Proyecto_Final_Aplicada2.Registros.RegistroObra" %>

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
								Registro de Obras
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
								<asp:TextBox runat="server" type="text" ID="textboxNombre" class="form-control" placeholder="Nombre" required />
							</div>

							<div class="form-group">
								<label for="textboxDescripcion">Descripcion</label>
								<asp:TextBox runat="server" type="text" ID="textboxDescripcion" class="form-control" placeholder="Descripcion" required />
							</div>

							<div class="form-group">
								<label for="textboxDireccion">Direccion</label>
								<asp:TextBox runat="server" type="text" ID="textboxDireccion" class="form-control" placeholder="Direccion" required />
							</div>

							<div class="form-group">
								<label for="textboxPresupuesto">Presupuesto</label>
								<asp:TextBox runat="server" type="number" ID="textboxPresupuesto" class="form-control" placeholder="Presupuesto" required />
							</div>

							<div class="form-group">
								<label for="textboxItbis">ITBIS</label>
								<asp:TextBox runat="server" type="number" ID="textboxItbis" class="form-control" placeholder="ITBIS" required />
							</div>

							<div class="form-group">
								<label for="textboxCostoEstimado">Costo Estimado</label>
								<asp:TextBox runat="server" type="number" ID="textboxCostoEstimado" class="form-control" placeholder="Costo Estimado" required />
							</div>


							<div class="form-group">
								<label for="textboxCostoFinal">Costo Final</label>
								<asp:TextBox runat="server" type="number" ID="textboxCostoFinal" class="form-control" placeholder="Costo Final" required />
							</div>

							<div class="form-group">
								<label for="textboxSubTotal">Sub Total</label>
								<asp:TextBox runat="server" type="number" ID="textboxSubTotal" class="form-control" placeholder="Sub Total" required />
							</div>

							<div class="form-group">
								<label for="textboxTotal">Total</label>
								<asp:TextBox runat="server" type="number" ID="textboxTotal" class="form-control" placeholder="Total" required />
							</div>


							
							<div class="form-group">
								<label for="textboxBeneficioEstimado">Beneficio Estimado</label>
								<asp:TextBox runat="server" type="number" ID="textboxBeneficioEstimado" class="form-control" placeholder="Beneficio Estimado" required />
							</div>

							<hr />

							<div class="form-group">
								<label for="dropdownMateriales">Materiales</label>
								<asp:DropDownList ID="dropdownMateriales" runat="server"></asp:DropDownList>
							</div>

							<asp:GridView ID="GridViewMateriales" runat="server"></asp:GridView>

							<div class="form-group">
								<label for="dropdownActividades">Actividades</label>
								<asp:DropDownList ID="dropdownActividades" runat="server"></asp:DropDownList>
							</div>
							<asp:GridView ID="GridViewActividades" runat="server"></asp:GridView>

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
