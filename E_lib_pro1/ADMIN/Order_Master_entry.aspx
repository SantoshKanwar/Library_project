        
<%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Order_Master_entry.aspx.cs" Inherits="AURO.ADMIN.Order_Master_entry" Title="Order_Master Entry Page" %>  
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
<script>
    $(function () {
      
        $("#ContentPlaceHolder1_txtOm_date").datepicker({ showAnim: "drop" });
        $("#ContentPlaceHolder1_txtOrd_date").datepicker({ showAnim: "fold" });

    });
	</script>
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
  
    <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Order-Master Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtOm_id" runat="server" Visible="False"></asp:TextBox>  
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
                    Member id :  
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
                    Order-Master Number :<asp:Label ID="Label6" runat="server" ForeColor="Red" 
                        Text="*"></asp:Label>
&nbsp;</td>  
                <td>  
                    <asp:TextBox ID="txtOm_number" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtOm_number" 
                        ErrorMessage="Enter The Order-Master Number" ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Order-Master Date :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtOm_date" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Order bill No :  
                    <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtOrder_bill_no" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtOrder_bill_no" 
                        ErrorMessage="Enter The Order Bill-No" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Order Date :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtOrd_date" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Suplier Name :  
                    <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtSup_name" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtSup_name" ErrorMessage="Enter The Supplier Name" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Suplier Address :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtSup_address" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSup_address" 
                        ErrorMessage="Enter The Supplier Address" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Suplier City :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtSup_city" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtSup_city" ErrorMessage="Enter The Supplier City" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Suplier Mobile :  
                    <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtSup_mobile" runat="server"></asp:TextBox>  
                </td>  
                <td id="red">  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtSup_mobile" 
                        ErrorMessage="Enter Supplier Mobile Number" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtSup_mobile" ErrorMessage="Mobile With 10 Digit" 
                        MaximumValue="9999999999" MinimumValue="1111111111" Type="Double" 
                        ForeColor="Red">*</asp:RangeValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Suplier Email :  
                    <asp:Label ID="Label10" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </td>  
                <td>  
                    <asp:TextBox ID="txtSup_email" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtSup_email" ErrorMessage="Enter The Supplier E-Mail" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtSup_email" ErrorMessage="E-mail is Not Valid" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ForeColor="Red">*</asp:RegularExpressionValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Gross Amount :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtGross_amt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtGross_amt" ErrorMessage="Enter The Gross Amount" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Discount Amount :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtDis_amt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtDis_amt" ErrorMessage="Enter The Discount" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Net Amount :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtNet_amt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtNet_amt" ErrorMessage="Enter The Net-Amount" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Is paid :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlPaid" runat="server">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    User1 :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtUser1" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ControlToValidate="txtUser1" ErrorMessage="Enter The User">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Status :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlStatus" runat="server">
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
        

