<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Accession_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Accession Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtAcc_id" runat="server" Visible="False"></asp:TextBox>  
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
                    Book Name :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlBook_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource2" DataTextField="Title" DataValueField="Book_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Book_id], [Title] FROM [Book_Master]">
                    </asp:SqlDataSource>
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
                    <asp:DropDownList ID="ddlCollege_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource3" DataTextField="College_Name" 
                        DataValueField="College_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [College_id], [College_Name] FROM [College]">
                    </asp:SqlDataSource>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>
            <tr>  
                <td>  
                    Accession 
                    Code :&nbsp;</td>  
                <td>  
                    <asp:TextBox ID="txtAcc_code" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtAcc_code" ErrorMessage="Enter The Accession Code" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Location :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtLocation" ErrorMessage="Enter The Location" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Is issue :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Status :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DropDownList2" runat="server">
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
                    <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" />
                </td>  
            </tr>  
        </table>  
    </center>
</asp:Content>
