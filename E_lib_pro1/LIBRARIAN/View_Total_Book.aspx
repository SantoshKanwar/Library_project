<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="View_Total_Book.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm27" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
                <tr>
                    <td>
                        <h2>
                            Total Book Information 
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="title">Title</asp:ListItem>
        
                            <asp:ListItem Value="author">Author</asp:ListItem>
                            <asp:ListItem Value="subject">Subject</asp:ListItem>
                            <asp:ListItem Value="book_type">Book type</asp:ListItem>
                            <asp:ListItem Value="edition">Edition</asp:ListItem>
                            <asp:ListItem Value="publisher">Publisher</asp:ListItem>
        
                            <asp:ListItem Value="Dep_name"></asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" 
                            onclick="btnShow_Click1" />
                        &nbsp;<asp:Button ID="Button1" CssClass="button" runat="server" Text="Report" 
                            onclick="Button1_Click"  />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book_type" 
                                    SortExpression="Book_type" />
                                <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                                    SortExpression="Publisher" Visible="False" />
                                <asp:BoundField DataField="NoOfBook" HeaderText="NoOfBook" 
                                    SortExpression="NoOfBook" />
                                <asp:BoundField DataField="IssueBooks" HeaderText="IssueBooks" 
                                    SortExpression="IssueBooks" />
                                <asp:BoundField DataField="AvlBooks" HeaderText="AvlBooks" 
                                    SortExpression="AvlBooks" />
                                <asp:BoundField DataField="Book_id" HeaderText="Book_id" 
                                    SortExpression="Book_id" />
                                <asp:BoundField DataField="College_Name" HeaderText="College_Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Dep_name" HeaderText="Dep_name" 
                                    SortExpression="Dep_name" Visible="False" />
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
                            SelectCommand="SELECT [Title], [Author], [Book_type], [Publisher], [NoOfBook], [IssueBooks], [AvlBooks], [Book_id], [College_Name], [Dep_name] FROM [ViewAcc_book_Ava]">
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRec" Visible="false" runat="server" Text="Total Records : "></asp:Label>
                    </td>
                </tr>
            </table>  
</asp:Content>
