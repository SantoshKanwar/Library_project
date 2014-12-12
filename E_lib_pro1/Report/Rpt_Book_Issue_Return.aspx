<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt_Book_Issue_Return.aspx.cs" Inherits="E_lib_pro1.Report.Rpt_Book_Issue_Return" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%-- <link rel="stylesheet" href="../jquery-ui-1.10.0/themes/base/jquery.ui.all.css">
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    Search On:
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Member_Name"></asp:ListItem>
                        <asp:ListItem Value="Role"></asp:ListItem>
                        <asp:ListItem Value="Acc_code"></asp:ListItem>
                        <asp:ListItem Value="Title"></asp:ListItem>
                        <asp:ListItem Value="Author"></asp:ListItem>
                        <asp:ListItem Value="Edition"></asp:ListItem>
                        <asp:ListItem Value="Issue_dt"></asp:ListItem>
                        <asp:ListItem Value="Return_dt"></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
&nbsp; Search By:
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnReport" runat="server" CssClass="button" Text="Search" color="red" 
                        onclick="btnReport_Click1" />
<asp:Button ID="btnExcel" runat="server" CssClass="button" Text="Excel" color="red" 
                        onclick="btnExcel_Click" />
<asp:Button ID="btnPDF" runat="server" CssClass="button" Text="PDF" color="red" 
                        onclick="btnPDF_Click" />
                    <br />
                    Date :
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; To :
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
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
