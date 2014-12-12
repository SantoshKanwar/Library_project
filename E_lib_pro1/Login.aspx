<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_lib_pro1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<center>
        <table>
            <tr>
                <td rowspan="9">
                   
                    <asp:Image ID="Image1" runat="server" Height="250px" ImageUrl="~/img/login.png" 
                        Width="250px" />
                   
                </td>
                <td colspan="3" align="center" >
                    <h3>User Login</h3></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="login" 
                        Text="Admin" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Checked="True" GroupName="login" 
                        Text="Member" />
                &nbsp;</td>
            </tr>
            <tr>
                <td >
                    E-Mail :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    Password :</td>
                <td style="margin-left: 80px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="128px" 
                        TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Button ID="Button1" runat="server" ForeColor="Black" 
                        onclick="Button1_Click" Text="Login" />
                    &nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Member.aspx">New 
                    Registration</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ForgotPass.aspx">Forgot 
                    Password</asp:HyperLink>
                </td>
            </tr>
            </table>
            </center>
</asp:Content>
