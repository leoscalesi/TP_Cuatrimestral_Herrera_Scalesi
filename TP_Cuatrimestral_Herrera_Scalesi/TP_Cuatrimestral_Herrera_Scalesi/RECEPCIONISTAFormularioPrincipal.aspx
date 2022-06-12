<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioPrincipal.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RecepcionistaFormularioPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
           <asp:Button ID="btnNuevoPaciente" runat="server" Text="Nuevo Paciente" />
        </div>
    
        <div>
            <asp:Button ID="btnBrindarTurnos" runat="server" Text="Brindar Turnos" />
        </div>
    
        <div>
            <asp:Button ID="btnSalir" runat="server" Text="Salir" />
        </div>
    
    </form>
    
    
</body>
</html>
