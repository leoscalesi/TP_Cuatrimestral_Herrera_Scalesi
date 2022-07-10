<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAListadoSugerencias.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAListadoSugerencias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSugerencias" runat="server" Text="Algunos horarios disponibles son:"></asp:Label>
        </div>
        <div>
            <asp:GridView ID="grvSugerencias" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvSugerencias_SelectedIndexChanged">

                <columns>
                        
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
                        <asp:BoundField HeaderText="IdPersona" DataField="Id"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" />
                        
                </columns>


            </asp:GridView>
        </div>
        
    </form>
</body>
</html>
