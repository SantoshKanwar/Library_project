<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt_Member.aspx.cs" Inherits="E_lib_pro1.Report.Rpt_Member" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp; Search On&nbsp;<strong> </strong>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                        <asp:ListItem Value="Role"></asp:ListItem>
                        <asp:ListItem Value="Member_code"></asp:ListItem>
                    </asp:DropDownList>
&nbsp;<strong> </strong>
                    Search By : 
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Search " onclick="Button1_Click" />
<asp:Button ID="Button2" runat="server" Text="Excel " onclick="Button2_Click" />
<asp:Button ID="Button3" runat="server" Text="PDF " onclick="Button3_Click" />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
&nbsp;
                    <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                        AutoDataBind="true" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
