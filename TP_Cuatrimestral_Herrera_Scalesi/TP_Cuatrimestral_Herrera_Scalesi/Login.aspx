<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.LOGIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
</head>
<body class="estiloBody">
    <form id="form1" runat="server">
        
      <div class="card" id="estiloCardLogin">
            <div class="card-header">
               <h2>LOGIN</h2>
            </div>
    
          <div class="card-body">

               <div>
                  <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
               </div>

               <div>
                  <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
               </div>

          </div> 
    
          <div class="card-footer">
             <asp:Button ID="btnIngresar" runat="server" Text="INGRESAR" style="background-color: lightgreen;" />
          </div>
     </div>
    
    
    
    </form>
</body>
</html>
