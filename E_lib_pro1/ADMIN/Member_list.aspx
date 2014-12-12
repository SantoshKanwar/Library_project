        
 <%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMIN.Master" AutoEventWireup="true" CodeBehind="Member_list.aspx.cs" Inherits="AURO.ADMIN.Member_list" Title="Member List Page" %>
     <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     </asp:Content>
     <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
               <table style="width: 100%;">
                <tr>
                    <td align="center">
                        <h2>
                            Member List
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
        
                            <asp:ListItem Value="mem_id">Mem id</asp:ListItem>
                            <asp:ListItem Value="Member_Name"></asp:ListItem>
                            <asp:ListItem Value="gender">Gender</asp:ListItem>
                            <asp:ListItem Value="city">City</asp:ListItem>
                            <asp:ListItem Value="role">Role</asp:ListItem>
                            <asp:ListItem Value="Des_name">Des_name</asp:ListItem>
                            <asp:ListItem Value="Dep_name">Dep_name</asp:ListItem>
                            <asp:ListItem Value="College_Name">College Name</asp:ListItem>
                            <asp:ListItem Value="member_code">Member code</asp:ListItem>
        
                            <asp:ListItem Value="College_id"></asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;<asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" OnClick="btnNewEntry_Click" />
                        <asp:Button ID="btnReport" runat="server" CssClass="button" 
                            OnClick="btnReport_Click" Text="Report" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" DataKeyNames="Mem_id" DataSourceID="SqlDataSource1" 
                            ForeColor="#333333" GridLines="None" AllowPaging="True" 
                            AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                             <asp:HyperLinkField DataNavigateUrlFields="Mem_id"    
            DataNavigateUrlFormatString="~/ADMIN/Member_entry.aspx?action=del&amp;id={0}" 
            Text="Delete" />
        <asp:HyperLinkField DataNavigateUrlFields="Mem_id" 
            DataNavigateUrlFormatString="~/ADMIN/Member_entry.aspx?action=upd&amp;id={0}" 
            Text="Edit" />

                                <asp:BoundField DataField="Mem_id" HeaderText="Mem id" ReadOnly="True" 
                                    SortExpression="Mem_id" Visible="False" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="Gender" HeaderText="Gender" 
                                    SortExpression="Gender" Visible="False" />
                                <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" 
                                    Visible="False" />
                                <asp:BoundField DataField="Address" HeaderText="Address" 
                                    SortExpression="Address" Visible="False" />
                                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" 
                                    Visible="False" />
                                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                                <asp:BoundField DataField="Mobile" HeaderText="Mobile" 
                                    SortExpression="Mobile" />
                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                <asp:TemplateField HeaderText="Photo">
                                    <ItemTemplate>
                                       
                                       <asp:Image ID="Image1" ImageUrl='<%# "~/img/" + Eval("photo") %>' runat="server" Width="80px" />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Des_name" HeaderText="Des name" 
                                    SortExpression="Des_name" Visible="False" />
                                <asp:BoundField DataField="Dep_name" HeaderText="Dep name" 
                                    SortExpression="Dep_name" Visible="False" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Member_code" HeaderText="Member code" 
                                    SortExpression="Member_code" Visible="False" />
                                <asp:BoundField DataField="Status" HeaderText="Status" 
                                    SortExpression="Status" Visible="False" />
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
                            SelectCommand="SELECT * FROM [VMember]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRec" Visible="false" runat="server" Text="Total Records : "></asp:Label>
                    </td>
                </tr>
            </table>  
 
        
        </asp:Content>
        
        

