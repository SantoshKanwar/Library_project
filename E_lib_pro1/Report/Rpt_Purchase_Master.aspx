﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt_Purchase_Master.aspx.cs" Inherits="E_lib_pro1.Report.Rpt_Purchase_Master" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <%--  <link rel="stylesheet" href="../jquery-ui-1.10.0/themes/base/jquery.ui.all.css">
	<script src="../jquery-ui-1.10.0/jquery-1.9.0.js"></script>
    <script src="../jquery-ui-1.10.0/jquery-1.9.0.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.core.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.widget.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect-blind.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect-bounce.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect-clip.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect-drop.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect-fold.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.effect-slide.js"></script>
	<script src="../jquery-ui-1.10.0/ui/jquery.ui.datepicker.js"></script>
    <script src="../jquery-ui-1.10.0/ui/jquery.ui.button.js"></script>
	<link rel="stylesheet" href="../jquery-ui-1.10.0/demos/demos.css">

<script>
    $(function () {
        $("#TextBox2").datepicker({ showAnim: "bounce" });

        $("#TextBox3").datepicker({ showAnim: "bounce" });
    });
	</script>--%>
    <style type="text/css">
        .style1
        {
            font-size: larger;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td>
                                <span class="style1">
                                <strong>&nbsp; 
                                </strong> Search On :
            </span>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="Member_Name"></asp:ListItem>
                <asp:ListItem Value="Om_date">Pm_date</asp:ListItem>
                <asp:ListItem Value="Pur_date"></asp:ListItem>
                <asp:ListItem Value="Sup_name"></asp:ListItem>
            </asp:DropDownList>
                                &nbsp;<span class="style1">Search By</span>
            <strong>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="style1"></asp:TextBox>
                                </strong>&nbsp;<strong><asp:Button ID="Button1" runat="server" Text="Search" 
                                    onclick="Button1_Click"/>
                                <asp:Button ID="Button2" runat="server" Text="Excel" onclick="Button2_Click"/>
                                <asp:Button ID="Button3" runat="server" Text="PDF" onclick="Button3_Click"/>
            <br class="style1" />
                                <span class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </span></strong><span class="style1">
                            </td>
                        </tr>
                        <tr>
                            <td>
                                </span>
                                <span class="style1">DATE :</span>
            <strong>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="style1"></asp:TextBox>
                                <span class="style1">&nbsp; </span>
                                </strong>
                                <span class="style1">TO : </span>
            <strong>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="style1"></asp:TextBox>
                                <span class="style1">
                                <br />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Label" style="font-size: smaller"></asp:Label>
&nbsp;
                                <asp:Label ID="Label2" runat="server" Text="Label" style="font-size: smaller"></asp:Label>
                                </span></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                                    AutoDataBind="true" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>