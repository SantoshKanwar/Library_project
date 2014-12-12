<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Book_Issue_Return_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
    $(function () {
        $("#ContentPlaceHolder1_txtIssue_dt").datepicker({ showAnim: "bounce" });
        $("#ContentPlaceHolder1_txtDue_dt").datepicker({ showAnim: "drop" });
        $("#ContentPlaceHolder1_txtReturn_dt").datepicker({ showAnim: "fold" });

    });
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Book-Issue&amp;Return Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Bir id :  
                </td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtBir_id" runat="server"></asp:TextBox>  
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
                    Mem id :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlMem_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource2" DataTextField="Mem_id" DataValueField="Mem_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Mem_id] FROM [Member]"></asp:SqlDataSource>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Acc id :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlAcc_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource3" DataTextField="Acc_id" DataValueField="Acc_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Acc_id] FROM [Accession]"></asp:SqlDataSource>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Issue Date :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtIssue_dt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Issue days :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtIssue_days" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtIssue_days" ErrorMessage="Enter The Issue Days" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Due Date:  
                </td>  
                <td>  
                    <asp:TextBox ID="txtDue_dt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtDue_dt" ErrorMessage="Enter the Due Date" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Return Date:  
                </td>  
                <td>  
                    <asp:TextBox ID="txtReturn_dt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtReturn_dt" ErrorMessage="Enter The Return Date" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Due day :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtDue_day" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtDue_day" ErrorMessage="Enter The Due day" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Is return :  
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
                    Is fine :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DropDownList2" runat="server">
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
                    Fine rate :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtFine_rate" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtFine_rate" ErrorMessage="Enter The Fine Rate" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Fine amount :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtFine_amt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtFine_amt" ErrorMessage="Enter The Fine Amount" 
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
                        ShowMessageBox="True" ShowSummary="False" ForeColor="Red" />
                </td>  
            </tr>  
        </table>  
    </center>  

</asp:Content>
