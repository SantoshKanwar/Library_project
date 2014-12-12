<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt_ViewTotalbook.aspx.cs" Inherits="E_lib_pro1.Report.Rpt_ViewTotalbook" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    Search on
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Title"></asp:ListItem>
                        <asp:ListItem Value="Author"></asp:ListItem>
                        <asp:ListItem Value="Publisher"></asp:ListItem>
                        <asp:ListItem Value="NoOfBook"></asp:ListItem>
                        <asp:ListItem Value="IssueBooks"></asp:ListItem>
                        <asp:ListItem Value="AvlBooks"></asp:ListItem>
                        <asp:ListItem Value="Dep_name"></asp:ListItem>
                        <asp:ListItem Value="College_Name"></asp:ListItem>
                    </asp:DropDownList>
&nbsp;Search By
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
                    <asp:Button ID="Button2" runat="server" Text="Excel" onclick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="PDF" onclick="Button3_Click" />
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
