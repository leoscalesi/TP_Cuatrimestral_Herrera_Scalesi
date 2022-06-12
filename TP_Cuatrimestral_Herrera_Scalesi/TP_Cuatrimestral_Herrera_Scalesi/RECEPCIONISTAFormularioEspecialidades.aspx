<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioEspecialidades.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAFormularioEspecialidades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad"></asp:Label>
            <asp:DropDownList ID="ddlEspecialidades" runat="server"></asp:DropDownList>
        </div>
    
        <div>
            <asp:Button ID="btnContinuarAHorariosMedicos" runat="server" Text="Continuar" />
        </div>
    
    </form>
</body>
</html>
