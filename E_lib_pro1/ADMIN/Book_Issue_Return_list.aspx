        
 <%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Book_Issue_Return_list.aspx.cs" Inherits="AURO.ADMIN.Book_Issue_Return_list" Title="Book_Issue_Return List Page" %>
     <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     </asp:Content>
     <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
               <table style="width: 100%;">
                <tr>
                    <td align="left">
                        <h2>
                            Book-Issue &amp; Return List
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
        
                            <asp:ListItem Value="bir_id">Bir id</asp:ListItem>
                            <asp:ListItem Value="reg_id">Reg id</asp:ListItem>
                            <asp:ListItem Value="mem_id">Mem id</asp:ListItem>
                            <asp:ListItem Value="acc_id">Acc id</asp:ListItem>
                            <asp:ListItem Value="issue_dt">Issue dt</asp:ListItem>
                            <asp:ListItem Value="issue_days">Issue days</asp:ListItem>
                            <asp:ListItem Value="due_dt">Due dt</asp:ListItem>
                            <asp:ListItem Value="return_dt">Return dt</asp:ListItem>
                            <asp:ListItem Value="due_day">Due day</asp:ListItem>
                            <asp:ListItem Value="is_return">Is return</asp:ListItem>
                            <asp:ListItem Value="is_fine">Is fine</asp:ListItem>
                            <asp:ListItem Value="fine_rate">Fine rate</asp:ListItem>
                            <asp:ListItem Value="fine_amt">Fine amt</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;&nbsp;&nbsp;<asp:Button ID="btnReport" runat="server" CssClass="button" 
                            onclick="btnReport_Click1" Text="Report" />
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AllowPaging="True" 
                            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                            DataKeyNames="Bir_id" 
                            EmptyDataText="There are no data records to display." ForeColor="#333333" 
                            GridLines="None" DataSourceID="SqlDataSource1" 
                          >
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                             	<asp:HyperLinkField DataNavigateUrlFields="Bir_id"    
            DataNavigateUrlFormatString="~/ADMIN/Book_Issue_Return_entry.aspx?action=view&amp;id={0}" 
            Text="View" />
       <%-- <asp:HyperLinkField DataNavigateUrlFields="Bir_id" 
            DataNavigateUrlFormatString="~/ADMIN/Book_Issue_Return_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />--%>
                                <asp:BoundField DataField="Bir_id" HeaderText="Bir id" 
                                    SortExpression="Bir_id" ReadOnly="True" Visible="False" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    SortExpression="Member_Name" ReadOnly="True" />
                                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                                <asp:BoundField DataField="Acc_code" HeaderText="Acc code" 
                                    SortExpression="Acc_code" Visible="False" />
                                <asp:BoundField DataField="Title" HeaderText="Title" 
                                    SortExpression="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book type" 
                                    SortExpression="Book_type" Visible="False" />
                                <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                    SortExpression="Edition" />
                                <asp:BoundField DataField="Issue_dt" HeaderText="Issue dt" 
                                    SortExpression="Issue_dt" />
                                <asp:BoundField DataField="Issue_days" HeaderText="Issue days" 
                                    SortExpression="Issue_days" Visible="False" />
                                <asp:BoundField DataField="Due_dt" HeaderText="Due dt" 
                                    SortExpression="Due_dt" Visible="False" />
                                <asp:BoundField DataField="Return_dt" HeaderText="Return dt" 
                                    SortExpression="Return_dt" />
                                <asp:BoundField DataField="Due_day" HeaderText="Due day" 
                                    SortExpression="Due_day" Visible="False" />
                                <asp:CheckBoxField DataField="Is_return" HeaderText="Is return" 
                                    SortExpression="Is_return" />
                                <asp:CheckBoxField DataField="Is_fine" HeaderText="Is fine" 
                                    SortExpression="Is_fine" Visible="False" />
                                <asp:BoundField DataField="Fine_rate" HeaderText="Fine rate" 
                                    SortExpression="Fine_rate" Visible="False" />
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
                            SelectCommand="SELECT * FROM [VBook_Issue_Return]"></asp:SqlDataSource>
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
        
        

