﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm24" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h3>Dashboard</h3>
	<div class="quoteOfDay">
	<b>Quote of the day :</b><br>
	<i style="color: #5b5b5b;">"If you think you can, you really can"</i>
	</div>
		<%--<div class="shortcutHome">
		<a href="College_list.aspx"><img src="auro-css/img/posting.png"><br>College</a>
		</div>--%>
		<div class="shortcutHome">
		<a href="Book_Issue_entry.aspx"><img src="auro-css/img/halaman.png"><br>Book Issue</a>
		</div>
        <div class="shortcutHome">
		<a href="Book_Return_entry.aspx"><img src="auro-css/img/photo.png"><br>Book Return</a>
		</div>
       
		<div class="shortcutHome">
		<a href="Member_list.aspx"><img src="auro-css/img/halaman.png"><br>Member</a>
		</div>
		<div class="shortcutHome">
		<a href="Book_Master_list.aspx"><img src="auro-css/img/template.png"><br>Book Detail</a>
		</div>
		<div class="shortcutHome">
		<a href="Book_Issue_Return_list.aspx"><img src="auro-css/img/quote.png"><br>Book Issue&Return</a>
		</div>
        <div class="shortcutHome">
		<a href="Accession_list.aspx"><img src="auro-css/img/bukutamu.png"><br>Accession</a>
		</div>
		<div class="shortcutHome">
		<a href="News_list.aspx"><img src="auro-css/img/bukutamu.png"><br>News</a>
		</div>
        <div class="shortcutHome">
		<a href="Reservation_list.aspx"><img src="auro-css/img/halaman.png"><br>Reservation</a>
		</div>
        <div class="shortcutHome">
		<a href="Fine_list.aspx"><img src="auro-css/img/bukutamu.png"><br>Fine</a>
		</div>
        <div class="shortcutHome">
		<a href="Order_Detail_list.aspx"><img src="auro-css/img/halaman.png"><br>Order Detail</a>
		</div>
        <div class="shortcutHome">
		<a href="Order_Master_list.aspx"><img src="auro-css/img/bukutamu.png"><br>Order Master</a>
		</div>
		<div class="shortcutHome">
		<a href="Purchase_Detail_list.aspx"><img src="auro-css/img/halaman.png"><br>Purchase Detail</a>
		</div>
		<div class="shortcutHome">
		<a href="Purchase_Master_list.aspx"><img src="auro-css/img/bukutamu.png"><br>Purchase Master</a>
		</div>
		<div class="shortcutHome">
		<a href="Setting_list.aspx"><img src="auro-css/img/halaman.png"><br>Setting</a>
		</div>
        
		<div class="clear"></div>
		
		 
	 
</asp:Content>
