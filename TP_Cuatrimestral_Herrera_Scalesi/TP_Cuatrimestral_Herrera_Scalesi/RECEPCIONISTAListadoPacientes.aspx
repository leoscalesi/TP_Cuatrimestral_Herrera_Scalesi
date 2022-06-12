<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAListadoPacientes.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAListadoPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lblFiltro" runat="server" Text="Filtrar"></asp:Label>
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
        </div>
        
        <div>
            <asp:GridView ID="dgvListadoPacientes" runat="server"></asp:GridView>
        </div>
    
        <div>
            <asp:Button ID="btnContinuarAEspecialidades" runat="server" Text="Continuar" />
        </div>
    
    </form>
   
</body>
</html>
