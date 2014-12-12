<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt_Accession.aspx.cs" Inherits="E_lib_pro1.Report.Rpt_Accession" %>

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
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Search On :
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Acc_code">Acc_Code</asp:ListItem>
                        <asp:ListItem Value="Book_type">Book Type</asp:ListItem>
                        <asp:ListItem Value="Title"></asp:ListItem>
                        <asp:ListItem Value="Author"></asp:ListItem>
                        <asp:ListItem Value="Location"></asp:ListItem>
                        <asp:ListItem Value="Is_issue"></asp:ListItem>
                        <asp:ListItem Value="Edition"></asp:ListItem>
                    </asp:DropDownList>
&nbsp; Search&nbsp; By:
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server"  Text="Search" 
                        ForeColor="Red" onclick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server"   Text="Excel" 
                        ForeColor="Red" onclick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server"   Text="PDf" 
                        ForeColor="Red" onclick="Button3_Click" />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label" style="font-weight: 700"></asp:Label>&nbsp &nbsp
                    <asp:Label ID="Label3" runat="server" Text="Label" style="font-weight: 700"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                        AutoDataBind="true" ToolPanelView="None" />
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
