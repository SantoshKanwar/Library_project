<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_lib_pro1.ADMIN.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="auro-css/auro-style.css"> <!--pemanggilan file css-->

</head>
<body>
    <form id="form1" runat="server">
  <div id="header">
	<div class="inHeaderLogin"></div>
</div>

<div id="loginForm">
	<div class="headLoginForm">
	Login Administrator
	</div>
	<div class="fieldLogin">
	<form method="POST" action="">
	<label>Username</label><br>
	<input type="text" class="login"><br>
	<label>Password</label><br>
	<input type="password" class="login"><br>
	<input type="submit" class="button" value="Login">
	</form>
	</div>
</div>




    </form>
</body>
</html>
