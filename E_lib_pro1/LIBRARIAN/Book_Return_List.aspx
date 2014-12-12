<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Book_Return_List.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm29" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <table style="width: 100%;">
                <tr>
                    <td align="left">
                        <h2>
                            Member List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                            <asp:ListItem Value="Role"></asp:ListItem>
                            <asp:ListItem Value="Member_code">Member code</asp:ListItem>
        
                            <asp:ListItem Value="Acc_code"></asp:ListItem>
                            <asp:ListItem Value="Location"></asp:ListItem>
                            <asp:ListItem Value="Issue_dt"></asp:ListItem>
                            <asp:ListItem Value="Return_dt"></asp:ListItem>
        
                        </asp:DropDownList>
                        Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        <asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" 
                            OnClick="btnNewEntry_Click" Width="84px" />
                        <asp:Button CssClass="button" ID="btnReport" runat="server" Text="Report" 
                            OnClick="btnReport_Click" Width="62px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Bir_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None" AllowPaging="True" 
                            AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("mem_id","~/LIBRARIAN/Member_entry.aspx?action=del&amp;id={0}") %>' Text="Delete"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("mem_id","~/LIBRARIAN/Member_entry.aspx?action=upd&amp;id={0}") %>' Text="Update"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Bir_id" HeaderText="Bir_id" ReadOnly="True" 
                                    SortExpression="Bir_id" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member_Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="Des_name" HeaderText="Des_name" 
                                    SortExpression="Des_name" />
                                <asp:BoundField DataField="Dep_name" HeaderText="Dep_name" 
                                    SortExpression="Dep_name" />
                                <asp:BoundField DataField="College_Name" HeaderText="College_Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Member_code" HeaderText="Member_code" 
                                    SortExpression="Member_code" />
                                <asp:BoundField DataField="Acc_code" HeaderText="Acc_code" 
                                    SortExpression="Acc_code" />
                                <asp:BoundField DataField="Location" HeaderText="Location" 
                                    SortExpression="Location" />
                                <asp:BoundField DataField="Issue_dt" HeaderText="Issue_dt" 
                                    SortExpression="Issue_dt" />
                                <asp:BoundField DataField="Issue_days" HeaderText="Issue_days" 
                                    SortExpression="Issue_days" />
                                <asp:BoundField DataField="Due_dt" HeaderText="Due_dt" 
                                    SortExpression="Due_dt" />
                                <asp:BoundField DataField="Return_dt" HeaderText="Return_dt" 
                                    SortExpression="Return_dt" />
                                <asp:BoundField DataField="Due_day" HeaderText="Due_day" 
                                    SortExpression="Due_day" />
                                <asp:CheckBoxField DataField="Is_return" HeaderText="Is_return" 
                                    SortExpression="Is_return" />
                                <asp:CheckBoxField DataField="Is_fine" HeaderText="Is_fine" 
                                    SortExpression="Is_fine" />
                                <asp:BoundField DataField="Fine_rate" HeaderText="Fine_rate" 
                                    SortExpression="Fine_rate" />
                                <asp:BoundField DataField="Fine_amt" HeaderText="Fine_amt" 
                                    SortExpression="Fine_amt" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                            SelectCommand="SELECT * FROM [VBook_Return]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRec" Visible="false" runat="server" Text="Total Records : "></asp:Label>
                    </td>
                </tr>
            </table>  

</asp:Content>
