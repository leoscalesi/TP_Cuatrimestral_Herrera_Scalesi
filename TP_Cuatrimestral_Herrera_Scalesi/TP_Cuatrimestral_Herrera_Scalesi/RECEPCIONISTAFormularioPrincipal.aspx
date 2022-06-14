<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioPrincipal.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RecepcionistaFormularioPrincipal" %>

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
        
        <h2 style="padding:40px;">
            <asp:Label ID="lblHolaRecepcionista" runat="server" Text="Hola "></asp:Label>
        </h2>

        <h4 style="text-align:center">Que desea hacer?</h4>
        
        <div class="card" id="estiloCardRecepcionistaPrincipal">
            
            <div class="card-body">
                
                <div style="padding-top:30px">
                    <asp:Button ID="btnNuevoPaciente" runat="server" Text="Nuevo Paciente" style="background-color:lightgreen;" OnClick="btnNuevoPaciente_Click"/>
                </div>
    
                <div style="padding-top:30px;">
                    <asp:Button ID="btnBrindarTurnos" runat="server" Text="Brindar Turnos" style="background-color: lightblue;" OnClick="btnBrindarTurnos_Click"/>
                </div>
            </div>
            
            <div class="card-footer" style="padding-top:30px;">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" style="background-color:lightcoral;" />
            </div>
        </div>
    
    
    </form>
    
    
</body>
</html>
