<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Change_Password.aspx.cs" Inherits="E_lib_pro1.ADMIN.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<center>
<table>
 <tr>
            <td colspan="3">
                <center> <h2>Change Password </h2></center> </td>
        </tr>
 <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
 <tr>
            <td>
                Username :</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter Username.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Old
                Password :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Enter Password.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                New Password :</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="Enter New Password.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Confirm Password :</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="Enter Confirm Password.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="Button1" CssClass="button" runat="server" Text="Change Password" 
                    onclick="Button1_Click" />
                &nbsp;<asp:Button ID="Button2" CssClass="button" runat="server" Text="Reset" onclick="Button2_Click" />
            </td>
        </tr>
        </table>
        </center>

</asp:Content>
