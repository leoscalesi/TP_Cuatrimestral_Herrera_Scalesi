﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioCargarObservaciones.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAFormularioCargarObservaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Carga de Observaciones</h2>
        </div>
        <div>
            <asp:TextBox ID="txtObservaciones" runat="server" TextMode="MultiLine" Height="100px" Width="300px"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-success" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </form>
</body>
</html>
