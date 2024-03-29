﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="Proyecto_Final_Aplicada2.Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrapcss">
<link href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" type="text/css" rel="stylesheet" />
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">
    <link rel="stylesheet" href="loginstyle.css">

    <script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js" type="text/javascript"></script>
    <title></title>
</head>
<body>
  

    <form runat="server">
    <div id="logreg-forms">
        <form id="formLogin" class="form-signin">
            <h1 class="h3 mb-3 font-weight-normal" style="text-align: center"> Sign in</h1>
           
            <p style="text-align:center"> OR  </p>
            <asp:TextBox runat="server" id="textboxemaillogin" type="email" class="form-control" placeholder="Email address" required="true" autofocus=""/>
            <asp:TextBox runat="server" ID="textboxpasswordlogin" type="password" class="form-control" placeholder="Password" required="true"/>
            
            <asp:button runat="server" ID="buttonIniciarSesion" formnovalidate OnClick="buttonIniciarSesion_Click" class="btn btn-success btn-block" type="submit"/>
            <a href="#" id="forgot_pswd">Forgot password?</a>
            <hr>
            <!-- <p>Don't have an account!</p>  -->
            <button class="btn btn-primary btn-block" type="button" id="btn-signup"><i class="fas fa-user-plus"></i> Sign up New Account</button>
            </form>

            
            <asp:panel runat="server" id="formRegister" class="form-signup">               
                
                <p style="text-align:center">OR</p>

                <asp:TextBox runat="server" ID="textboxNombre" type="text" class="form-control" placeholder="Nombre" required="true"/>
                <asp:TextBox runat="server" type="email" id="textboxemailr" class="form-control" placeholder="Email address" required="true"/>
                <asp:TextBox runat="server" type="password" id="textboxpassr" class="form-control" placeholder="Password" required="true"/>
                <asp:TextBox runat="server" type="password" id="textboxrepeatpassr" class="form-control" placeholder="Repeat Password" required="true"/>

                <asp:button runat="server" ID="buttonRegitrarse" OnClick="buttonRegitrarse_Click" formnovalidate class="btn btn-primary btn-block" type="submit" Text="Sign Up" />
                <a href="#" id="cancel_signup"><i class="fas fa-angle-left"></i> Back</a>
            </asp:panel>
            <br>
            
    </div>
        </form>
    <p style="text-align:center">
      <script>
            function toggleResetPswd(e){
    e.preventDefault();
    $('#logreg-forms .form-signin').toggle() // display:block or none
    $('#logreg-forms .form-reset').toggle() // display:block or none
}

function toggleSignUp(e){
    e.preventDefault();
    $('#logreg-forms .form-signin').toggle(); // display:block or none
    $('#logreg-forms .form-signup').toggle(); // display:block or none
}

          $(() => {
              // Login Register Form
              $('#logreg-forms #forgot_pswd').click(toggleResetPswd);
              $('#logreg-forms #cancel_reset').click(toggleResetPswd);
              $('#logreg-forms #btn-signup').click(toggleSignUp);
              $('#logreg-forms #cancel_signup').click(toggleSignUp);
          });

          </script>
    </p>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="/script.js"></script>

</body>
</html>
