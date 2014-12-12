<%@ Page Title="" Language="C#" MasterPageFile="~/USER/user.Master" AutoEventWireup="true" CodeBehind="Reservation_entry.aspx.cs" Inherits="E_lib_pro1.USER.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>
    $(function () {

        $("#ContentPlaceHolder1_txtRes_date").datepicker({ showAnim: "fold" });

    });
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Book Reservation<asp:SqlDataSource 
                            ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                            SelectCommand="SELECT DISTINCT [Book_id], [Title] FROM [VAccession] WHERE ([Is_issue] = @Is_issue)">
                            <SelectParameters>
                                <asp:Parameter DefaultValue="1" Name="Is_issue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Book Title :  
                    </td>  
                <td>  
                    
                    <asp:TextBox ID="txtBook_title" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtBook_title" ErrorMessage="Enter The Book Title" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Book Author :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtBook_author" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtBook_author" ErrorMessage="Enter The Book author" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Book Publisher :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtBook_publisher" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtBook_publisher" 
                        ErrorMessage="Enter The Book Publisher" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td colspan="3">  
                    &nbsp;  
                    <asp:Label ID="Label1" runat="server"></asp:Label>  
                    &nbsp;  
                    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>  
                </td>  
            </tr>  
            <tr>  
                <td align="center" colspan="3">  
                    <asp:Button CssClass="button" ID="btnSubmit" runat="server" Text="Submit"   
                        onclick="btnSubmit_Click" />  
                    &nbsp;<asp:Button CssClass="button" ID="btnReset" runat="server" Text="Reset"   
                        onclick="btnReset_Click" />  
                &nbsp;</td>  
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
