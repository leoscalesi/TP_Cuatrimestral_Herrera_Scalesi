<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTACalendarioTurnos.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTACalendarioTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
        
        <div class="card" >
        

            <div class ="card-header">
                
                <div>
                    <h2>Seleccione la fecha del turno</h2>
                </div>
            
            </div>
            <div class ="card-body">
                
                <div>
                  <asp:Calendar ID="calCalendario" runat="server" SelectedDate="2022-07-16" OnSelectionChanged="calCalendario_SelectionChanged" BorderColor="#660033" CellPadding="10" CellSpacing="5" CssClass="accordion-item" ></asp:Calendar>
                </div>
            
            </div>
            
            <div class ="card-footer">
                
               <div>
                
                   <asp:DropDownList ID="ddlHorarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHorarios_SelectedIndexChanged"></asp:DropDownList>
                   
                   <asp:Button ID="btnCargarObservaciones" CssClass="btn btn-info" runat="server" Text="Observaciones" OnClick="btnCargarObservaciones_Click" />

               </div>
               <div>
                     
               </div>
            </div>
            
        
        </div>
    
    </form>
</body>
</html>
