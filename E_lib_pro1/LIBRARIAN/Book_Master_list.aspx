<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Book_Master_list.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm6" %>
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
                            Book-Master List
                           
                        </h2>
                         <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
                   <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
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
        
                            <asp:ListItem Value="book_id">Book id</asp:ListItem>
                            <asp:ListItem Value="pdate">Pdate</asp:ListItem>
                            <asp:ListItem Value="author">Author</asp:ListItem>
                            <asp:ListItem Value="title">Title</asp:ListItem>
                            <asp:ListItem Value="subject">Subject</asp:ListItem>
                            <asp:ListItem Value="book_type">Book type</asp:ListItem>
                            <asp:ListItem Value="edition">Edition</asp:ListItem>
                            <asp:ListItem Value="publisher_place">Publisher place</asp:ListItem>
                            <asp:ListItem Value="publisher">Publisher</asp:ListItem>
                            <asp:ListItem Value="volume">Volume</asp:ListItem>
        
                        </asp:DropDownList>
                        Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        <asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" OnClick="btnNewEntry_Click" />
                        <asp:Button CssClass="button" ID="Report" runat="server" Text="Report" OnClick="btnReport_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Book_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None" AllowPaging="True" 
                            AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                             <asp:HyperLinkField DataNavigateUrlFields="Book_id"    
            DataNavigateUrlFormatString="~/LIBRARIAN/Book_Master_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="Book_id" 
            DataNavigateUrlFormatString="~/LIBRARIAN/Book_Master_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />
                                <asp:BoundField DataField="Book_id" HeaderText="Book_id" ReadOnly="True" 
                                    SortExpression="Book_id" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book_type" 
                                    SortExpression="Book_type" />
                                <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                    SortExpression="Edition" />
                                <asp:BoundField DataField="Publisher_place" HeaderText="Publisher_place" 
                                    SortExpression="Publisher_place" />
                                <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                                    SortExpression="Publisher" />
                                <asp:BoundField DataField="Pdate" HeaderText="Pdate" SortExpression="Pdate" />
                                <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                                <asp:BoundField DataField="Pages" HeaderText="Pages" SortExpression="Pages" />
                                <asp:BoundField DataField="Volume" HeaderText="Volume" 
                                    SortExpression="Volume" />
                                <asp:BoundField DataField="Source" HeaderText="Source" 
                                    SortExpression="Source" />
                                <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                                <asp:BoundField DataField="Bill_no" HeaderText="Bill_no" 
                                    SortExpression="Bill_no" />
                                <asp:BoundField DataField="Book_no" HeaderText="Book_no" 
                                    SortExpression="Book_no" />
                                <asp:BoundField DataField="More_info" HeaderText="More_info" 
                                    SortExpression="More_info" />
                                <asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />
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
                            SelectCommand="SELECT [Book_id], [Author], [Title], [Book_type], [Edition], [Publisher_place], [Publisher], [Pdate], [Year], [Pages], [Volume], [Source], [Cost], [Bill_no], [Book_no], [More_info], [Photo] FROM [Book_Master]">
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
