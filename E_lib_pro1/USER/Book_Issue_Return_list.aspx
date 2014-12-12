<%@ Page Title="" Language="C#" MasterPageFile="~/USER/user.Master" AutoEventWireup="true" CodeBehind="Book_Issue_Return_list.aspx.cs" Inherits="E_lib_pro1.USER.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
               <table style="width: 100%;">
               <tr>
               <td>
                   <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp
                   <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                   </td>
               </tr>
                <tr>
                    <td>
                        <h2>
                            Book-Issue &amp; Return 
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="member_name">Member Name</asp:ListItem>
        
                            <asp:ListItem Value="acc_id">Acc Code</asp:ListItem>
                            <asp:ListItem Value="issue_days">Issue days</asp:ListItem>
                            <asp:ListItem Value="due_day">Due day</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AllowPaging="True" 
                            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                            DataKeyNames="Bir_id" 
                            EmptyDataText="There are no data records to display." ForeColor="#333333" 
                            GridLines="None" DataSourceID="SqlDataSource1">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    SortExpression="Member_Name" ReadOnly="True" />
                                <asp:BoundField DataField="Acc_code" HeaderText="Acc code" 
                                    SortExpression="Acc_code" />
                                <asp:BoundField DataField="Title" HeaderText="Title" 
                                    SortExpression="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book type" 
                                    SortExpression="Book_type" />
                                <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                    SortExpression="Edition" />
                                <asp:BoundField DataField="Issue_dt" HeaderText="Issue dt" 
                                    SortExpression="Issue_dt" />
                                <asp:BoundField DataField="Issue_days" HeaderText="Issue days" 
                                    SortExpression="Issue_days" />
                                <asp:BoundField DataField="Due_dt" HeaderText="Due dt" 
                                    SortExpression="Due_dt" />
                                <asp:BoundField DataField="Return_dt" HeaderText="Return dt" 
                                    SortExpression="Return_dt" />
                                <asp:BoundField DataField="Due_day" HeaderText="Due day" 
                                    SortExpression="Due_day" />
                                <asp:BoundField DataField="Fine_rate" HeaderText="Fine rate" 
                                    SortExpression="Fine_rate" />
                                <asp:BoundField DataField="Fine_amt" HeaderText="Fine amt" 
                                    SortExpression="Fine_amt" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                            SelectCommand="SELECT * FROM [VBook_Issue_Return]">
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRec" Visible="false" runat="server" Text="Total Records : "></asp:Label>
                    </td>
                </tr>
            </table>  
            </ContentTemplate>
            </asp:UpdatePanel>
        


</asp:Content>
