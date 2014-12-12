        
 <%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="News_list.aspx.cs" Inherits="AURO.ADMIN.News_list" Title="News List Page" %>
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
                            News List
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
        
                            <asp:ListItem Value="news_id">News id</asp:ListItem>
                            <asp:ListItem Value="news_date">News date</asp:ListItem>
                            <asp:ListItem Value="title">Title</asp:ListItem>
                            <asp:ListItem Value="detail">Detail</asp:ListItem>
                            <asp:ListItem Value="status">Status</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
    <asp:GridView ID="Grid1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="News_id" 
                             
                            EmptyDataText="There are no data records to display." 
                            DataSourceID="SqlDataSource1">   
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>   
          <asp:HyperLinkField DataNavigateUrlFields="News_id"    
            DataNavigateUrlFormatString="~/ADMIN/News_entry.aspx?action=view&amp;id={0}" 
            Text="View" />
       <%-- <asp:HyperLinkField DataNavigateUrlFields="News_id" 
            DataNavigateUrlFormatString="~/ADMIN/News_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />--%>


        <asp:BoundField DataField="News_id" HeaderText="News id" ReadOnly="True" 
            SortExpression="News_id" />
        <asp:BoundField DataField="Reg_id" HeaderText="Reg id" 
            SortExpression="Reg_id" Visible="False" />
        <asp:BoundField DataField="News_date" HeaderText="News date" 
            SortExpression="News_date" />
        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
        <asp:BoundField DataField="Detail" HeaderText="Detail" 
            SortExpression="Detail" />
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
                            SelectCommand="SELECT * FROM [News]"></asp:SqlDataSource>
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
        
        

