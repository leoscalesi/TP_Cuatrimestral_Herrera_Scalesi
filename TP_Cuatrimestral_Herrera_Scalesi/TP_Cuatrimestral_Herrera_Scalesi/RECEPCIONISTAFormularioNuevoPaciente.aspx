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
                <h2 style="text-align:center;">Alta de pacientes</h2>
            </div>
            
            <form action="/action_page.php" class="was-validated">
               
                <div class="form-group">
                   <label for="firstname">Nombre:</label>
                   <input type="text" class="form-control" id="uname" placeholder="Ingrese nombre" name="firstname" required />
                   <div class="valid-feedback">Valid.</div>
                   <!--<div class="invalid-feedback">Por favor ingrese un nombre</div>-->
               </div>
               
               <div class="form-group">
                   <label for="lastname">Apellido:</label>
                   <input type="text" class="form-control" id="pwd" placeholder="Ingrese apellido" name="lastname" required />
                   <div class="valid-feedback">Valid.</div>
                   <!--<div class="invalid-feedback">Please fill out this field.</div>-->
               </div>
               
               <div class="form-group">
                   <label for="street">Dirección:</label>
                   <input type="text" class="form-control" id="uname" placeholder="Ingrese direccion" name="street" required />
                   <div class="valid-feedback">Valid.</div>
                   <!--<div class="invalid-feedback">Please fill out this field.</div>-->
               </div>
                          
               <div class="form-group">
                   <label for="dni">DNI:</label>
                   <input type="text" class="form-control" id="uname" placeholder="Ingrese DNI" name="DNI" required />
                   <div class="valid-feedback">Valid.</div>
                   <!--<div class="invalid-feedback">Please fill out this field.</div>-->
               </div>
                          
               <div class="form-group">
                   <label for="cuit">CUIT:</label>
                   <input type="text" class="form-control" id="uname" placeholder="Ingrese CUIT" name="CUIT" required />
                   <div class="valid-feedback">Valid.</div>
                   <!--<div class="invalid-feedback">Please fill out this field.</div>-->
               </div>
                          
               <div class="form-group">
                   <label for="Birthdate">Fecha de nacimiento (mm/dd/yyyy):</label>
                   <input type="text" class="form-control" id="uname" placeholder="Ingrese fecha de nacimiento" name="Birthdate" required />
                   <div class="valid-feedback">Valid.</div>
                   <!--<div class="invalid-feedback">Please fill out this field.</div>-->
               </div>
                        
               <!--<button type="submit" class="btn btn-success">Submit</button>-->
                   
                <div>
                    <asp:Button ID="btnGuardarNuevoPaciente" CssClass="btn btn-success" runat="server" Text="GUARDAR" />
                </div>

           </form>
            
            
            <div class="card-footer">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" />
            </div>
        </div>
    </form>
</body>
</html>
