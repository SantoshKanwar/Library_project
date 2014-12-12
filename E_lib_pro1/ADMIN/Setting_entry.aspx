        
<%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Setting_entry.aspx.cs" Inherits="AURO.ADMIN.Setting_entry" Title="Setting Entry Page" %>  
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
  
    <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Setting Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtSet_id" runat="server" Visible="False"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Reg id :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlReg_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource1" DataTextField="Reg_id" 
                        DataValueField="Reg_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Reg_id] FROM [Registration]"></asp:SqlDataSource>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    College Name :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlCollege_id" runat="server" Height="25px" Width="150px">  
                    </asp:DropDownList>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Mem role :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">Faculty</asp:ListItem>
                        <asp:ListItem Value="2">student</asp:ListItem>
                    </asp:DropDownList>
                </td>  
                <td>  
                    &nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Due day :  
                    <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtDue_day" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtDue_day" ErrorMessage="Enter The Due Day" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Total book :  
                    <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtTotal_book" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtTotal_book" ErrorMessage="Enter Total Book" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Fine per day :  
                    <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtFine_per_day" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtFine_per_day" ErrorMessage="Enter Fine Per Day" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;  
                </td>  
                <td>  
                    <asp:Label ID="Label1" runat="server"></asp:Label>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td align="center" colspan="3">  
                    <asp:Button CssClass="button" ID="btnSubmit" runat="server" Text="Submit"   
                        onclick="btnSubmit_Click" />  
                    &nbsp;<asp:Button CssClass="button" ID="btnReset" runat="server" Text="Reset"   
                        onclick="btnReset_Click" />  
                </td>  
            </tr>  
            <tr>  
                <td align="center" colspan="3">  
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" />
                </td>  
            </tr>  
        </table>  
    </center>  
</asp:Content>  
        

