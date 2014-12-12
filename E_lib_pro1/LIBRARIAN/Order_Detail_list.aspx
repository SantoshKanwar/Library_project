<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Order_Detail_list.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm16" %>
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
                            Order-Detail List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>&nbsp
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="od_id">Od id</asp:ListItem>
                            <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                            <asp:ListItem Value="Om_number">Om number</asp:ListItem>
                            <asp:ListItem Value="Om_date">Om date</asp:ListItem>
                            <asp:ListItem Value="Sup_name">Sup name</asp:ListItem>
                            <asp:ListItem Value="Title"></asp:ListItem>
        
                            <asp:ListItem Value="Author"></asp:ListItem>
                            <asp:ListItem Value="Book_type">Book type</asp:ListItem>
                            <asp:ListItem Value="Edition"></asp:ListItem>
                            <asp:ListItem Value="College_Name">College Name</asp:ListItem>
                            <asp:ListItem Value="Ord_date">Ord date</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        <asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" OnClick="btnNewEntry_Click" />
                        <asp:Button CssClass="button" ID="btnReport" runat="server" Text="Report" OnClick="btnReport_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Od_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>


                            <asp:HyperLinkField DataNavigateUrlFields="Od_id"    
            DataNavigateUrlFormatString="~/LIBRARIAN/Order_Detail_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="Od_id" 
            DataNavigateUrlFormatString="~/LIBRARIAN/Order_Detail_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />

                                <asp:CommandField ShowDeleteButton="True" />
                                <asp:CommandField CancelText="" DeleteText="" ShowEditButton="True" />

                                <asp:BoundField DataField="Qty" HeaderText="Qty" 
                                    SortExpression="Qty" />
                                <asp:BoundField DataField="Rate" HeaderText="Rate" SortExpression="Rate" 
                                    Visible="False" />
                                <asp:BoundField DataField="Amount" HeaderText="Amount" 
                                    SortExpression="Amount" />
                                <asp:BoundField DataField="Od_id" HeaderText="Od_id" 
                                    SortExpression="Od_id" ReadOnly="True" Visible="False" />
                                <asp:BoundField DataField="Om_number" HeaderText="Om_number" 
                                    SortExpression="Om_number" Visible="False" />
                                <asp:BoundField DataField="Om_date" HeaderText="Om_date" 
                                    SortExpression="Om_date" />
                                <asp:BoundField DataField="Ord_date" HeaderText="Ord_date" 
                                    SortExpression="Ord_date" />
                                <asp:BoundField DataField="Sup_name" HeaderText="Sup_name" 
                                    SortExpression="Sup_name" />
                                <asp:BoundField DataField="Sup_mobile" HeaderText="Sup_mobile" 
                                    SortExpression="Sup_mobile" />
                                <asp:BoundField DataField="College_id" HeaderText="College_id" 
                                    SortExpression="College_id" Visible="False" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" Visible="False" />
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book_type" 
                                    SortExpression="Book_type" Visible="False" />
                                <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                    SortExpression="Edition" Visible="False" />
                                <asp:BoundField DataField="College_Name" HeaderText="College_Name" 
                                    SortExpression="College_Name" Visible="False" />
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
                            SelectCommand="SELECT * FROM [VOrder_Detail]"></asp:SqlDataSource>
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
