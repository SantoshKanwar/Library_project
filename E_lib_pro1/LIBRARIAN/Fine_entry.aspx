<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Fine_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>
    $(function () {
        $("#ContentPlaceHolder1_txtFine_date").datepicker({ showAnim: "bounce" });


    });
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Fine Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtFine_id" runat="server" Visible="False"></asp:TextBox>  
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
                    Reciept No :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtRec_no" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtRec_no" ErrorMessage="Enter Recipt Number" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Fine date :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtFine_date" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFine_date" 
                        ErrorMessage="Enter Fine Date" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    EnrollMent :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlMem_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource2" DataTextField="Member_code" 
                        DataValueField="Mem_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Mem_id], [Member_code] FROM [Member]">
                    </asp:SqlDataSource>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Fine Amount :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtFine_amt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtFine_amt" ErrorMessage="Enter The Fine Amount" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Rec Amount :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtRec_amt" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtRec_amt" ErrorMessage="Enter Receive Amount" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Detail :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtDetail" ErrorMessage="Enter The Detail" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Recive by :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtRec_by" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtRec_by" ErrorMessage="Enter The Receiver Name" 
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
