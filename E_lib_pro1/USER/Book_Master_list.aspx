<%@ Page Title="" Language="C#" MasterPageFile="~/USER/user.Master" AutoEventWireup="true" CodeBehind="Book_Master_list.aspx.cs" Inherits="E_lib_pro1.USER.WebForm2" %>
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
                        <h2>
                            Book Information 
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
        
                            <asp:ListItem Value="title">Title</asp:ListItem>
        
                            <asp:ListItem Value="author">Author</asp:ListItem>
                            <asp:ListItem Value="subject">Subject</asp:ListItem>
                            <asp:ListItem Value="book_type">Book type</asp:ListItem>
                            <asp:ListItem Value="edition">Edition</asp:ListItem>
                            <asp:ListItem Value="publisher">Publisher</asp:ListItem>
                            <asp:ListItem Value="year">Year</asp:ListItem>
                            <asp:ListItem Value="pages">Pages</asp:ListItem>
                            <asp:ListItem Value="volume">Volume</asp:ListItem>
        
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
                            DataKeyNames="Book_id" 
                            EmptyDataText="There are no data records to display." ForeColor="#333333" 
                            GridLines="None" DataSourceID="SqlDataSource1">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:TemplateField HeaderText="Photo">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Book_Img/" + Eval("photo") %>' Width="80px" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:BoundField DataField="Title" HeaderText="Title" 
                                    SortExpression="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Subject" HeaderText="Subject" 
                                    SortExpression="Subject" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book type" 
                                    SortExpression="Book_type" />
                                <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                    SortExpression="Edition" />
                                <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                                    SortExpression="Publisher" />
                                <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                                <asp:BoundField DataField="Pages" HeaderText="Pages" SortExpression="Pages" />
                                <asp:BoundField DataField="Volume" HeaderText="Volume" 
                                    SortExpression="Volume" />
                                <asp:BoundField DataField="Source" HeaderText="Source" 
                                    SortExpression="Source" />
                                <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                                <asp:BoundField DataField="Book_no" HeaderText="Book no" 
                                    SortExpression="Book_no" />
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
                            SelectCommand="SELECT * FROM [Book_Master]"></asp:SqlDataSource>
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
