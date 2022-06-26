﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAListadoPacientes.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAListadoPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
<link rel="stylesheet" href="estilos/estilos.css"/>
    <title></title>
</head>
<body class="estiloBody">
    <form id="form1" runat="server">
        
    <div class="card" id="estiloRecepcionistaListadoPacientes">

        <div class="card-header" style="text-align:center">
            <h2>Listado de pacientes</h2>
            <div>
                <img src="img/paciente.png" cssclass="img-fluid" width="70" alt="img paciente" />
            </div>
        </div>

        <div class="card-body">
            <div>
                <asp:Label ID="lblFiltro" runat="server" Text="Filtro"></asp:Label>
                <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                <asp:Button ID="btbFiltro" runat="server" Text="Buscar" OnClick="btbFiltro_Click" />
                <br />
                <br />
                <asp:GridView ID="dgvListadoPacientes" OnSelectedIndexChanged="dgvListadoPacientes_SelectedIndexChanged" OnRowDeleting="dgvListadoPacientes_RowDeleting" AutoGenerateColumns="false" cssclass="table table-bordered d-sm-table-cell table-info align-middle text-center align-center"  runat="server">
                    <columns>
                        <asp:BoundField HeaderText="ID" DataField="Id"/>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
                        <asp:BoundField HeaderText="DNI" DataField="Dni"/>
                        <asp:BoundField HeaderText="CUIT" DataField="Cuit"/>
                        <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion"/>
                        <asp:BoundField HeaderText="Email" DataField="Email"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" HeaderText="Modificar" />
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" ControlStyle-CssClass="btn btn-danger" HeaderText="Eliminar" />
                    </columns>
                 </asp:GridView>
            </div>
        </div>    

        
        <div class="card-footer">
            <div>
                <asp:Button ID="btnVolverAFormularioPrincipal" runat="server" Text="Regresar" OnClick="btnVolverAFormularioPrincipal_Click" />
            </div>
        </div>
    </div>
    </form>
   
</body>
</html>
