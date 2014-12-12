<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Fine_list.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm10" %>
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
                            Fine List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="fine_id">Fine id</asp:ListItem>
                            <asp:ListItem Value="rec_no">Rec no</asp:ListItem>
                            <asp:ListItem Value="fine_date">Fine date</asp:ListItem>
                            <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                            <asp:ListItem Value="College_Name">College Name</asp:ListItem>
                            <asp:ListItem Value="Dep_name">Dep name</asp:ListItem>
        
                            <asp:ListItem Value="Librarian"></asp:ListItem>
                            <asp:ListItem Value="Member_code">Member code</asp:ListItem>
        
                        </asp:DropDownList>
                        Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        <asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" OnClick="btnNewEntry_Click" />
                        <asp:Button ID="btnReport" runat="server" CssClass="button" 
                            OnClick="btnReport_Click" Text="Report" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" 
                            GridLines="None" AllowPaging="True" AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="Fine_id"    
            DataNavigateUrlFormatString="~/LIBRARIAN/Fine_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="Fine_id" 
            DataNavigateUrlFormatString="~/LIBRARIAN/Fine_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />

                                <asp:BoundField DataField="Fine_id" HeaderText="Fine id" 
                                    SortExpression="Fine_id" />
                                <asp:BoundField DataField="Rec_no" HeaderText="Rec no" 
                                    SortExpression="Rec_no" />
                                <asp:BoundField DataField="Fine_date" HeaderText="Fine date" 
                                    SortExpression="Fine_date" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="Fine_amt" HeaderText="Fine amt" 
                                    SortExpression="Fine_amt" />
                                <asp:BoundField DataField="Rec_amt" HeaderText="Rec amt" 
                                    SortExpression="Rec_amt" />
                                <asp:BoundField DataField="Detail" HeaderText="Detail" 
                                    SortExpression="Detail" />
                                <asp:BoundField DataField="Rec_by" HeaderText="Rec by" 
                                    SortExpression="Rec_by" Visible="False" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Dep_name" HeaderText="Dep name" 
                                    SortExpression="Dep_name" />
                                <asp:BoundField DataField="Librarian" HeaderText="Librarian" ReadOnly="True" 
                                    SortExpression="Librarian" />
                                <asp:BoundField DataField="College_id" HeaderText="Colleg _id" 
                                    SortExpression="College_id" Visible="False" />
                                <asp:BoundField DataField="Member_code" HeaderText="Member code" 
                                    SortExpression="Member_code" />
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
                            SelectCommand="SELECT * FROM [VFine]"></asp:SqlDataSource>
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
