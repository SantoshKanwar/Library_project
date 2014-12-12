        
 <%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Registration_list.aspx.cs" Inherits="AURO.ADMIN.Registration_list" Title="Registration List Page" %>
     <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     </asp:Content>
     <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
               <table style="width: 100%;">
                <tr>
                    <td align="center">
                        <h2>
                            Registration List
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
        
                            <asp:ListItem Value="Res_id"></asp:ListItem>
                            <asp:ListItem Value="Res_date"></asp:ListItem>
        
                            <asp:ListItem Value="Book_title">Res_date</asp:ListItem>
                            <asp:ListItem Value="Book_author">Username</asp:ListItem>
                            <asp:ListItem Value="Book_publisher"></asp:ListItem>
                            <asp:ListItem Value="Member_Name"></asp:ListItem>
                            <asp:ListItem Value="Status"></asp:ListItem>
                            <asp:ListItem Value="College_Name"></asp:ListItem>
                            <asp:ListItem Value="Dep_name"></asp:ListItem>
                            <asp:ListItem Value="College_id"></asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;<asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" OnClick="btnNewEntry_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Res_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                             <asp:HyperLinkField DataNavigateUrlFields="Reg_id"    
            DataNavigateUrlFormatString="~/ADMIN/Registration_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="Reg_id" 
            DataNavigateUrlFormatString="~/ADMIN/Registration_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />

                                <asp:BoundField DataField="Res_id" HeaderText="Res id" ReadOnly="True" 
                                    SortExpression="Res_id" />
                                <asp:BoundField DataField="Res_date" HeaderText="Res date" 
                                    SortExpression="Res_date" />
                                <asp:BoundField DataField="Book_title" HeaderText="Book title" 
                                    SortExpression="Book_title" />
                                <asp:BoundField DataField="Book_author" HeaderText="Book author" 
                                    SortExpression="Book_author" />
                                <asp:BoundField DataField="Book_publisher" HeaderText="Book publisher" 
                                    SortExpression="Book_publisher" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="Status" HeaderText="Status" 
                                    SortExpression="Status" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Dep_name" HeaderText="Dep name" 
                                    SortExpression="Dep_name" />
                                <asp:BoundField DataField="College_id" HeaderText="College id" 
                                    SortExpression="College_id" />
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
                            SelectCommand="SELECT * FROM [VReservation]"></asp:SqlDataSource>
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
        
        

