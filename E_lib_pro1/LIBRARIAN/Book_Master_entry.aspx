<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Book_Master_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script>
    $(function () {
        $("#ContentPlaceHolder1_txtPdate").datepicker({ showAnim: "bounce" });


    });
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Book-Master Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtBook_id" runat="server" Visible="False"></asp:TextBox>  
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
                    Purchase date :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPdate" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Author :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtAuthor" ErrorMessage="Enter The Book Author" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Title :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtTitle" ErrorMessage="Enter The Book Title" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Subject :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtSubject" ErrorMessage="Enter The Subject" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Book type :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value=" Book">Book</asp:ListItem>
                        <asp:ListItem Value="Magazine">Magazine</asp:ListItem>
                    </asp:DropDownList>
                </td>  
                <td>  
                    &nbsp;  
                    </td>  
            </tr>  
            <tr>  
                <td>  
                    Edition :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtEdition" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtEdition" ErrorMessage="Enter The Edition" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Publisher place :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPublisher_place" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtPublisher_place" 
                        ErrorMessage="Enter The Publisher Place" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Publisher :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPublisher" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtPublisher" ErrorMessage="Enter The Publisher" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Year :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    </td>  
            </tr>  
            <tr>  
                <td>  
                    Pages :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtPages" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtPages" ErrorMessage="Enter The Pages" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Volume :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtVolume" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    </td>  
            </tr>  
            <tr>  
                <td>  
                    Source :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtSource" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    </td>  
            </tr>  
            <tr>  
                <td>  
                    Cost :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                        ControlToValidate="txtCost" ErrorMessage="Enter The Cost" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Bill no :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtBill_no" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="txtBill_no" ErrorMessage="Enter The Bill No" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Book no :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtBook_no" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                        ControlToValidate="txtBook_no" ErrorMessage="Enter The Book No" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    More info :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtMore_info" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                        ControlToValidate="txtMore_info" ErrorMessage="Enter The More Info" 
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
                    &nbsp;<asp:Image ID="Image1" runat="server" Height="89px" Width="96px" />
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
