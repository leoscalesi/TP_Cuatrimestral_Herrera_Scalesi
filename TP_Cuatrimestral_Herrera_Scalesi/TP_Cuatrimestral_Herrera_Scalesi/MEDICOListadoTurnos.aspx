<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MEDICOListadoTurnos.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.MEDICOListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
    <title></title>
</head>
<body class="estiloBody">
    <form id="form1" runat="server">
        
         <div class="card">
  
            <div class="card-header">
                <div >
                    <h2>
                    <asp:Label ID="lblHolaMedico" runat="server" Text="Hola "></asp:Label>
                    </h2>
                </div>
            </div>
  
            <div class="card-body">
                 <div>
                    <asp:GridView ID="dgvListadoTurnos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="dgvListadoTurnos_SelectedIndexChanged">

                      <columns>
                        
                        
                        <asp:BoundField HeaderText="Observaciones Medico" DataField="ObservacionesMedico"/>
                        <asp:BoundField HeaderText="Observaciones Paciente" DataField="ObservacionesPaciente"/>
                        <asp:BoundField HeaderText="Hora" DataField="HoraTurno"/>
                        <asp:BoundField HeaderText="Fecha Turno" DataField="FechaTurno"/>
                        <asp:BoundField HeaderText="Nombre" DataField="Persona.Nombre"/>
                        <asp:BoundField HeaderText="Apellido" DataField="Persona.Apellido"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" HeaderText="Agregar Diagnostico" />
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" ControlStyle-CssClass="btn btn-danger" HeaderText="Eliminar" />
                     
                      </columns>


                    </asp:GridView>
                 </div>
    
                 
            </div>
  
            <div class="card-footer">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" style="background-color: lightcoral;" OnClick="btnSalir_Click" />
            </div>
       
        </div>
    
    </form>

     

</body>
</html>
