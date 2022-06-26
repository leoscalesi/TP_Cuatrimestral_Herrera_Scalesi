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
        
       
        <div class="card" id="estiloCardRecepcionistaPrincipal">
            
             <div align="center">
            <img src="img/gestiondeturnos.png" alt="gestion turno"/>
            <h2 style="padding:40px;">
            <asp:Label ID="lblHolaRecepcionista" runat="server" Text="Hola "></asp:Label>
            </h2>
            </div>

            <div class="card-header">
                <img src="img/principal.png" width="70" alt="logo" />
                <h4 style="text-align:center">Que desea hacer?</h4>
            </div>
            <div class="card-body">
                <div style="padding-top:10px;">
                    <asp:Button ID="btnBrindarTurnos" CssClass=" btn" runat="server" Text=" Brindar Turnos " style="background-color: lightblue;" OnClick="btnBrindarTurnos_Click"/>
                </div>

                <div style="padding-top:30px">
                    <asp:Button ID="btnListadoPacientes" CssClass=" btn" runat="server" Text=" Lista Pacientes " style="background-color: darkcyan" OnClick="btnListadoPacientes_Click" />
                    <asp:Button ID="btnNuevoPaciente" CssClass=" btn" runat="server" Text="Nuevo Paciente" style="background-color:lightgreen;" OnClick="btnNuevoPaciente_Click"/>
                </div>

                <div style="padding-top:30px">
                    <asp:Button ID="btnListadoMedicos" CssClass=" btn btn" runat="server" Text=" Lista Medicos " style="background-color:  indianred" OnClick="btnListadoMedicos_Click" />
                    <asp:Button ID="btnNuevoMedico" CssClass=" btn" runat="server" Text="Nuevo Medico" style="background-color: dodgerblue" OnClick="btnNuevoMedico_Click" />
                </div>
           </div>
            
            <div class="card-footer" style="padding-top:30px;">
                 <div style="padding-bottom:10px">
                <asp:Button ID="btnSalir" CssClass=" btn" runat="server" Text="Salir" style="background-color: coral;" OnClick="btnSalir_Click" />
                </div>
            </div>
        </div>
    
    
    </form>
    
    
</body>
</html>
