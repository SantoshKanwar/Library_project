<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Purchase_Detail_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Purchase-Detail Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtPd_id" runat="server" Visible="False"></asp:TextBox>  
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
                    Purchase-Master 
                    Id :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlPm_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource2" DataTextField="Pm_id" DataValueField="Pm_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Pm_id] FROM [Purchase_Master]"></asp:SqlDataSource>
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
                        DataSourceID="SqlDataSource3" DataTextField="Title" DataValueField="Book_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
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
                    Quntity :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtQty" runat="server" AutoPostBack="True" 
                        ontextchanged="txtQty_TextChanged"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtQty" ErrorMessage="Enter The Quntity" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Rate :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtRate" runat="server" AutoPostBack="True" 
                        ontextchanged="txtRate_TextChanged"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtRate" ErrorMessage="Enter The Rate" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Amount :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtAmount" runat="server" ontextchanged="txtAmount_TextChanged" 
                        ></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtAmount" ErrorMessage="Enter The Amount" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
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
                    <asp:Button CssClass="button" ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click"   
                        />  
                    &nbsp;<asp:Button CssClass="button" ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click"   
                         />  
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
