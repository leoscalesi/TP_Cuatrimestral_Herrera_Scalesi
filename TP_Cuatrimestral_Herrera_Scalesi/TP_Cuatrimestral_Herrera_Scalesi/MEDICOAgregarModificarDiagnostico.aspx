<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MEDICOAgregarModificarDiagnostico.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.MEDICOAgregarModificarDiagnostico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
           <asp:Label ID="lblTituloDiagnostico" runat="server" Text="Diagnostico para el paciente: "></asp:Label>
        </div>
    
        <div>
            <asp:TextBox ID="txtDiagnostico" runat="server"></asp:TextBox>
        </div>
    
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
        </div>
    
        <div>
            <asp:Button ID="btnVolverATurnos" runat="server" Text="Volver a Turnos" />
        </div>
    </form>

    

</body>
</html>
