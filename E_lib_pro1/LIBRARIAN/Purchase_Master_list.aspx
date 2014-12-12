<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Purchase_Master_list.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm22" %>
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
                            Purchase-Master List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>&nbsp
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="pm_id">Pm id</asp:ListItem>
                            <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                            <asp:ListItem Value="pm_Number">Pm Number</asp:ListItem>
                            <asp:ListItem Value="pm_Date">Pm Date</asp:ListItem>
                            <asp:ListItem Value="pur_bill_no">Pur bill no</asp:ListItem>
                            <asp:ListItem Value="pur_date">Pur date</asp:ListItem>
                            <asp:ListItem Value="sup_name">Sup name</asp:ListItem>
                            <asp:ListItem Value="sup_City">Sup City</asp:ListItem>
        
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
                            CellPadding="4" DataKeyNames="Pm_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None" AllowPaging="True" 
                            AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="Pm_id"    
            DataNavigateUrlFormatString="~/LIBRARIAN/Purchase_Master_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="Pm_id" 
            DataNavigateUrlFormatString="~/LIBRARIAN/Purchase_Master_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />
                                <asp:BoundField DataField="Pm_id" HeaderText="Pm id" ReadOnly="True" 
                                    SortExpression="Pm_id" Visible="False" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="Pm_Number" HeaderText="Pm Number" 
                                    SortExpression="Pm_Number" Visible="False" />
                                <asp:BoundField DataField="Pm_Date" HeaderText="Pm Date" 
                                    SortExpression="Pm_Date" Visible="False" />
                                <asp:BoundField DataField="Pur_bill_no" HeaderText="Pur bill no" 
                                    SortExpression="Pur_bill_no" Visible="False" />
                                <asp:BoundField DataField="Pur_date" HeaderText="Pur date" 
                                    SortExpression="Pur_date" />
                                <asp:BoundField DataField="Sup_name" HeaderText="Sup name" 
                                    SortExpression="Sup_name" />
                                <asp:BoundField DataField="Sup_address" HeaderText="Sup address" 
                                    SortExpression="Sup_address" Visible="False" />
                                <asp:BoundField DataField="Sup_City" HeaderText="Sup City" 
                                    SortExpression="Sup_City" />
                                <asp:BoundField DataField="Sup_mobile" HeaderText="Sup mobile" 
                                    SortExpression="Sup_mobile" />
                                <asp:BoundField DataField="Sup_email" HeaderText="Sup email" 
                                    SortExpression="Sup_email" />
                                <asp:BoundField DataField="Gross_amt" HeaderText="Gross amt" 
                                    SortExpression="Gross_amt" Visible="False" />
                                <asp:BoundField DataField="Dis_amt" HeaderText="Dis amt" 
                                    SortExpression="Dis_amt" Visible="False" />
                                <asp:BoundField DataField="Net_amt" HeaderText="Net amt" 
                                    SortExpression="Net_amt" />
                                <asp:BoundField DataField="Is_paid" HeaderText="Is paid" 
                                    SortExpression="Is_paid" />
                                <asp:BoundField DataField="User1" HeaderText="User1" SortExpression="User1" 
                                    Visible="False" />
                                <asp:BoundField DataField="Status" HeaderText="Status" 
                                    SortExpression="Status" />
                                <asp:BoundField DataField="College_id" HeaderText="College id" 
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
                            SelectCommand="SELECT * FROM [VPurchase_Master]"></asp:SqlDataSource>
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
