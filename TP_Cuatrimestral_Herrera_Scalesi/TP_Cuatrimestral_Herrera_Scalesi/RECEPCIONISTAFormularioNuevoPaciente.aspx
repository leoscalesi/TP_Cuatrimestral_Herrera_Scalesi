<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioNuevoPaciente.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAFORMULARIONUEVOPACIENTE" %>

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
        
        <!--VA UN FORMULARIO-->
        
        <div class="card" id="estiloRecepcionistaNuevoPaciente">
            <div class="card-body">
                <h2>Alta de pacientes</h2>
            </div>
            <div class="card-footer">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" />
            </div>
        </div>
    </form>
</body>
</html>
