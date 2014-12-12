<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Member_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--<script>
    $(function () {
        $("#ContentPlaceHolder1_txtDob").datepicker({ showAnim: "bounce" });


    });
	</script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <center>  
        <table>  
            <tr>  
                <td align="center" colspan="3">  
                    <h2>  
                        Member Entry</h2>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    &nbsp;</td>  
                <td>  
                    <asp:TextBox ReadOnly="True" ID="txtMem_id" runat="server" Visible="False"></asp:TextBox>  
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
                    Username :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" 
                        ErrorMessage="Enter The UserName" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Password :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtPassword" 
                        ErrorMessage="Enter The Password" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ErrorMessage="Please enter valid Passord" ValidationExpression="\w{5-10}" 
                        ControlToValidate="txtPassword"></asp:RegularExpressionValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    First Name :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtF_name" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtF_name" 
                        ErrorMessage="Enter The First Name" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;</td>  
            </tr>  
            <tr>  
                <td>  
                    Last Name :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtL_name" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtL_name" ErrorMessage="Enter The Last Name" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Gender :  
                </td>  
                <td>  
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" 
                        GroupName="gender" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" 
                        GroupName="gender" />
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Dob :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Address :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtAddress" ErrorMessage="Enter The Address" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>  
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
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
                    Role :  
                </td>  
                <td>  
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>LIBRARIAN</asp:ListItem>
                        <asp:ListItem>FACULTY</asp:ListItem>
                        <asp:ListItem>STUDENT</asp:ListItem>
                    </asp:DropDownList>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
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
                    Email :  
                    </td>  
                <td>  
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Enter The E-Mail" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="E-Mail Is Not Valid" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ForeColor="Red">*</asp:RegularExpressionValidator>
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
                    &nbsp;  
                    <asp:Image ID="Image1" runat="server" Height="81px" Width="80px" />
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Designation Name:  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlDes_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource2" DataTextField="Des_name" DataValueField="Des_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Des_id], [Des_name] FROM [Designation]">
                    </asp:SqlDataSource>
                </td>  
                <td>  
                    &nbsp;  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Department Name :  
                </td>  
                <td>  
                    <asp:DropDownList ID="ddlDep_id" runat="server" Height="25px" Width="150px" 
                        DataSourceID="SqlDataSource3" DataTextField="Dep_name" DataValueField="Dep_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT [Dep_id], [Dep_name] FROM [Department]">
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
                        DataSourceID="SqlDataSource4" DataTextField="College_Name" 
                        DataValueField="College_id">  
                    </asp:DropDownList>  
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
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
                    Member code :  
                </td>  
                <td>  
                    <asp:TextBox ID="txtMember_code" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                    &nbsp;  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtMember_code" ErrorMessage="Enter The Member Code" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
