<%@ Page Title="" Language="C#" MasterPageFile="~/USER/user.Master" AutoEventWireup="true" CodeBehind="ViewBook.aspx.cs" Inherits="E_lib_pro1.USER.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
                <tr>
                    <td>
                        <h2>
                            Book Information 
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
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
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
                            DataKeyNames="Expr1">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" Visible="False" />
                                <asp:BoundField DataField="Dep_name" HeaderText="Dep name" 
                                    SortExpression="Dep_name" />
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Subject" HeaderText="Subject" 
                                    SortExpression="Subject" Visible="False" />
                                <asp:BoundField DataField="College_id" HeaderText="College id" 
                                    SortExpression="College_id" Visible="False" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book type" 
                                    SortExpression="Book_type" />
                                <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                                    SortExpression="Publisher" />
                                <asp:BoundField DataField="NoOfBook" HeaderText="NoOfBook" 
                                    SortExpression="NoOfBook" />
                                <asp:BoundField DataField="Book_id" HeaderText="Book id" 
                                    SortExpression="Book_id" />
                                <asp:BoundField DataField="IssueBooks" HeaderText="IssueBooks" 
                                    SortExpression="IssueBooks" />
                                <asp:BoundField DataField="AvlBooks" HeaderText="AvlBooks" 
                                    SortExpression="AvlBooks" />
                                <asp:BoundField DataField="Expr1" HeaderText="Expr1" ReadOnly="True" 
                                    SortExpression="Expr1" Visible="False" />
                                <asp:BoundField DataField="Dep_id" HeaderText="Dep id" SortExpression="Dep_id" 
                                    Visible="False" />
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
                            SelectCommand="SELECT * FROM [ViewAcc_book_Ava]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRec" Visible="false" runat="server" Text="Total Records : "></asp:Label>
                    </td>
                </tr>
            </table>  
</asp:Content>
