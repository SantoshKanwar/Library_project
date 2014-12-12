        
 <%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="College_list.aspx.cs" Inherits="AURO.ADMIN.College_list" Title="College List Page" %>
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
                            College List
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
        
                            <asp:ListItem Value="college_id">College id</asp:ListItem>
                            <asp:ListItem Value="college_Name">College Name</asp:ListItem>
                            <asp:ListItem Value="address">Address</asp:ListItem>
                            <asp:ListItem Value="city">City</asp:ListItem>
                            <asp:ListItem Value="college_code">College code</asp:ListItem>
                            <asp:ListItem Value="prefix">Prefix</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;<asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" OnClick="btnNewEntry_Click" />
                         &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="College_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None" AllowPaging="True" 
                            AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="College_id"    
            DataNavigateUrlFormatString="~/ADMIN/College_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="College_id" 
            DataNavigateUrlFormatString="~/ADMIN/College_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />  
                                <asp:BoundField DataField="College_id" HeaderText="College id" ReadOnly="True" 
                                    SortExpression="College_id" />
                                <asp:BoundField DataField="Reg_id" HeaderText="Reg id" 
                                    SortExpression="Reg_id" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Address" HeaderText="Address" 
                                    SortExpression="Address" />
                                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                                <asp:BoundField DataField="Mobile" HeaderText="Mobile" 
                                    SortExpression="Mobile" Visible="False" />
                                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" 
                                    Visible="False" />
                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                <asp:BoundField DataField="Website" HeaderText="Website" 
                                    SortExpression="Website" />
                                <asp:BoundField DataField="College_code" HeaderText="College code" 
                                    SortExpression="College_code" Visible="False" />
                                <asp:BoundField DataField="Prefix" HeaderText="Prefix" 
                                    SortExpression="Prefix" Visible="False" />
                                <asp:BoundField DataField="status" HeaderText="status" 
                                    SortExpression="status" Visible="False" />
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
                            SelectCommand="SELECT * FROM [College]"></asp:SqlDataSource>
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
        
        

