﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MEDICOListadoTurnos.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.MEDICOListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lblHolaMedico" runat="server" Text="Hola "></asp:Label>
        </div>
        
        <div>
            <asp:GridView ID="dgvListadoTurnos" runat="server"></asp:GridView>
        </div>
    
        <div>
            <asp:Button ID="btnModAgrDiagnostico" runat="server" Text="Agregar/Modificar Diagnostico" />
        </div>
    
        <div>
            <asp:Button ID="btnSalir" runat="server" Text="Salir" />
        </div>
    
    </form>

     

</body>
</html>
