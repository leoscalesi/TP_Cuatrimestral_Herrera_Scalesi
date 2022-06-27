<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuardadoExitoso.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.GuardadoExitoso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGuardadoExitoso" runat="server" Text="El registro se guardo/modifico exitosamente"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Menu principal" OnClick="btnVolver_Click" />
        </div>
    </form>
</body>
</html>
