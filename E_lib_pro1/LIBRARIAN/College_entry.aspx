<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="College_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        College Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtCollege_id" runat="server" Visible="False"></asp:TextBox>  
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
                        DataSourceID="SqlDataSource1" DataTextField="Reg_id" DataValueField="Reg_id">  
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
                    College Name :&nbsp;</td>  
                <td>  
                    <asp:TextBox ID="txtCollege_Name" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtCollege_Name" ErrorMessage="Enter College Name" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Address :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAddress" 
                        ErrorMessage="Enter The Address" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    City :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
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
                    </td>  
            </tr>  
            <tr>  
                <td>  
                    Mobile :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtMobile" ErrorMessage="Enter The Mobile Number" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtMobile" ErrorMessage="Mobile with 10 Digit" 
                        MaximumValue="9999999999" MinimumValue="1111111111" Type="Double" 
                        ForeColor="Red">*</asp:RangeValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Fax :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    </td>  
            </tr>  
            <tr>  
                <td>  
                    Email :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Enter E-Mail" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Website :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtWebsite" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtWebsite" ErrorMessage="Enter Website" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    College code :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtCollege_code" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtCollege_code" ErrorMessage="Enter The College Code" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Prefix :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPrefix" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtPrefix" ErrorMessage="Enter The Prefix" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Status :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DdlStatus" runat="server">
                        <asp:ListItem Value="1">Active</asp:ListItem>
                        <asp:ListItem Value="0">De-Active</asp:ListItem>
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
