<%@ Page Title="" Language="C#" MasterPageFile="~/USER/user.Master" AutoEventWireup="true" CodeBehind="Reservation_List.aspx.cs" Inherits="E_lib_pro1.USER.WebForm3" %>
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
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> &nbsp
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                
                
                <tr>
                    <td align="center">
                        <h2>
                            Reservation List
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
        
                            <asp:ListItem Value="res_id">Res id</asp:ListItem>
                            <asp:ListItem Value="reg_id">Reg id</asp:ListItem>
                            <asp:ListItem Value="res_date">Res date</asp:ListItem>
                            <asp:ListItem Value="book_title">Book title</asp:ListItem>
                            <asp:ListItem Value="book_author">Book author</asp:ListItem>
                            <asp:ListItem Value="book_publisher">Book publisher</asp:ListItem>
                            <asp:ListItem Value="mem_id">Mem id</asp:ListItem>
                            <asp:ListItem Value="status">Status</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;<asp:Button ID="btnNewEntry" runat="server" CssClass="button" 
                            Text="New Entry" onclick="btnNewEntry_Click" />
                        &nbsp;<asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Res_id" DataSourceID="SqlDataSource1" 
                            EmptyDataText="There are no data records to display." ForeColor="#333333" 
                            GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>


                               <asp:HyperLinkField DataNavigateUrlFields="Res_id"    
            DataNavigateUrlFormatString="~/ADMIN/Reservation_entry.aspx?action=view&amp;id={0}" 
            Text="View" />
        <%--<asp:HyperLinkField DataNavigateUrlFields="Res_id" 
            DataNavigateUrlFormatString="~/ADMIN/Reservation_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />--%>
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
                                 <asp:BoundField DataField="Dep_name" HeaderText="Dep name" 
                                     SortExpression="Dep_name" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Status" HeaderText="Status" 
                                    SortExpression="Status" />
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
                            SelectCommand="SELECT * FROM [VReservation]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
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
