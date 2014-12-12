        
<%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Registration_entry.aspx.cs" Inherits="AURO.ADMIN.Registration_entry" Title="Registration Entry Page" %>  
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
  
    <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Registration Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtReg_id" runat="server" Visible="False"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Username :&nbsp;<asp:Label ID="Label6" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="Enter The Username" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Password :&nbsp;<asp:Label ID="Label7" runat="server" 
                        ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtPassword" ErrorMessage="Enter The Password" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    First name :  
                    <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtF_name" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtF_name" ErrorMessage="Enter The First Name" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Last&nbsp; name :  
                    <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtL_name" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtL_name" ErrorMessage="Enter The Last Name" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Address :  
                    <asp:Label ID="Label13" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtAddress" ErrorMessage="Enter The Address" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    City :  
                    <asp:Label ID="Label14" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtCity" ErrorMessage="Enter The City" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Phone :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtPhone" ErrorMessage="Enter The Phone Number" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Mobile :  
                    <asp:Label ID="Label10" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>  
                <td>  
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtMobile" ErrorMessage="Mobile With 10 Digit" 
                        MaximumValue="9999999999" MinimumValue="1111111111" Type="Double" 
                        ForeColor="Red">*</asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtMobile" ErrorMessage="Enter The Mobile Number" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Email :  
                    <asp:Label ID="Label11" runat="server" ForeColor="Red" Text="*"></asp:Label>
                    </td>  
                <td>  
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Enter The E-Mail" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="E-mail is Not Valid" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ForeColor="Red">*</asp:RegularExpressionValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Seq que :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DdlSeq_que" runat="server">
                        <asp:ListItem>What is Your Favorate Color?</asp:ListItem>
                        <asp:ListItem>Who is Your Best Friend?</asp:ListItem>
                    </asp:DropDownList>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Answer :  
                    <asp:Label ID="Label12" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtAnswer" ErrorMessage="Enter The Answer" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Photo :  
                </td>  
                <td>  
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>  
                <td>  
                    &nbsp;<asp:Image ID="Image1" runat="server" Width="80px" />
                    &nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Status :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DdlStatus" runat="server">
                        <asp:ListItem Value="1">Active</asp:ListItem>
                        <asp:ListItem Value="0">De-Active</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>  
                <td>  
                    &nbsp;  
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
        

