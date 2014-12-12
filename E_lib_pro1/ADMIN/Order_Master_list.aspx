        
 <%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Order_Master_list.aspx.cs" Inherits="AURO.ADMIN.Order_Master_list" Title="Order_Master List Page" %>
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
                            Order-Master List
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
        
                            <asp:ListItem Value="om_id">Om id</asp:ListItem>
                            <asp:ListItem Value="Member_Name">Member_Name</asp:ListItem>
                            <asp:ListItem Value="om_number">Om number</asp:ListItem>
                            <asp:ListItem Value="om_date">Om date</asp:ListItem>
                            <asp:ListItem Value="order_bill_no">Order bill no</asp:ListItem>
                            <asp:ListItem Value="ord_date">Ord date</asp:ListItem>
                            <asp:ListItem Value="sup_name">Sup name</asp:ListItem>
                            <asp:ListItem Value="sup_city">Sup city</asp:ListItem>
        
                            <asp:ListItem Value="College_id"></asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;<asp:Button ID="btnReport" runat="server" CssClass="button" 
                            OnClick="btnReport_Click" Text="Report" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Om_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None" AllowPaging="True" 
                            AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="Om_id"    
            DataNavigateUrlFormatString="~/ADMIN/Order_Master_entry.aspx?action=view&amp;id={0}" 
            Text="View" />
                                <asp:BoundField DataField="Om_id" HeaderText="Om id" ReadOnly="True" 
                                    SortExpression="Om_id" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="F_name" HeaderText="F name" 
                                    SortExpression="F_name" Visible="False" />
                                <asp:BoundField DataField="L_name" HeaderText="L name" 
                                    SortExpression="L_name" Visible="False" />
                                <asp:BoundField DataField="Om_number" HeaderText="Om number" 
                                    SortExpression="Om_number" />
                                <asp:BoundField DataField="Om_date" HeaderText="Om date" 
                                    SortExpression="Om_date" />
                                <asp:BoundField DataField="Order_bill_no" HeaderText="Order bill no" 
                                    SortExpression="Order_bill_no" Visible="False" />
                                <asp:BoundField DataField="Ord_date" HeaderText="Ord date" 
                                    SortExpression="Ord_date" Visible="False" />
                                <asp:BoundField DataField="Sup_name" HeaderText="Sup name" 
                                    SortExpression="Sup_name" />
                                <asp:BoundField DataField="Sup_address" HeaderText="Sup address" 
                                    SortExpression="Sup_address" Visible="False" />
                                <asp:BoundField DataField="Sup_city" HeaderText="Sup city" 
                                    SortExpression="Sup_city" />
                                <asp:BoundField DataField="Sup_mobile" HeaderText="Sup mobile" 
                                    SortExpression="Sup_mobile" />
                                <asp:BoundField DataField="Sup_email" HeaderText="Sup email" 
                                    SortExpression="Sup_email" Visible="False" />
                                <asp:BoundField DataField="Gross_amt" HeaderText="Gross amt" 
                                    SortExpression="Gross_amt" Visible="False" />
                                <asp:BoundField DataField="Dis_amt" HeaderText="Dis amt" 
                                    SortExpression="Dis_amt" Visible="False" />
                                <asp:BoundField DataField="Net_amt" HeaderText="Net amt" 
                                    SortExpression="Net_amt" />
                                <asp:BoundField DataField="Is_paid" HeaderText="Is paid" 
                                    SortExpression="Is_paid" Visible="False" />
                                <asp:BoundField DataField="User1" HeaderText="User1" SortExpression="User1" 
                                    Visible="False" />
                                <asp:BoundField DataField="Status" HeaderText="Status" 
                                    SortExpression="Status" />
                                <asp:BoundField DataField="College_id" HeaderText="College_id" 
                                    SortExpression="College_id" Visible="False" />
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
                            SelectCommand="SELECT * FROM [VOrder_Master]"></asp:SqlDataSource>
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
        
        

