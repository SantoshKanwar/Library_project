<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt_Book_Issue.aspx.cs" Inherits="E_lib_pro1.Report.Rpt_Book_Issue" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link rel="stylesheet" href="../jquery-ui-1.10.0/themes/base/jquery.ui.all.css">
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
</asp:Content>
    <style type="text/css">
        .style1
        {
            font-size: larger;
            font-family: "Times New Roman", Times, serif;
        }
        .style2
        {
            font-size: larger;
            font-weight: normal;
            font-family: "Times New Roman", Times, serif;
        }
        .style3
        {
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td style="font-weight: 700">
                    <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span 
                        class="style1">&nbsp;</span></strong><span 
                        class="style2"> Search On :</span>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                        <asp:ListItem Value="Member_code">Member code</asp:ListItem>
                        <asp:ListItem Value="Des_name"></asp:ListItem>
                        <asp:ListItem Value="Acc_code"></asp:ListItem>
                        <asp:ListItem Value="Issue_dt"></asp:ListItem>
                        <asp:ListItem Value="Location"></asp:ListItem>
                        <asp:ListItem Value="Return_dt"></asp:ListItem>
                    </asp:DropDownList>
&nbsp;<span class="style3"> </span><span class="style2">Search By :</span>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" ForeColor="Red" Text="Search" 
                        onclick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" ForeColor="Red" Text="Excel" onclick="Button2_Click" 
                         />
                        <asp:Button ID="Button3" runat="server" ForeColor="Red" Text="PDF" onclick="Button3_Click" 
                         />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <span class="style1">&nbsp;<span class="style3">Date :</span></span><strong>&nbsp; </strong>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<span class="style2">To</span><strong>&nbsp; </strong>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;</td>
<tr><td><asp:Label ID="Label2" runat="server" Text="Label" CssClass="style1"></asp:Label>
    <span class="style1">&nbsp &nbsp
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </span></td></tr>
            </tr>
            <tr>
                <td>
                    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                        AutoDataBind="true" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
