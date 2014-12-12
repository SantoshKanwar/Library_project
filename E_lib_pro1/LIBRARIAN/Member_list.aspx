<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Member_list.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
                <tr>
                    <td align="left">
                        <h2>
                            Member List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="mem_id">Mem id</asp:ListItem>
                            <asp:ListItem Value="Member_Name">Member Name</asp:ListItem>
                            <asp:ListItem Value="Gender"></asp:ListItem>
                            <asp:ListItem Value="Dob"></asp:ListItem>
                            <asp:ListItem Value="City"></asp:ListItem>
                            <asp:ListItem Value="Role"></asp:ListItem>
                            <asp:ListItem Value="Des_name">Des name</asp:ListItem>
                            <asp:ListItem Value="Dep_name">Dep name</asp:ListItem>
                            <asp:ListItem Value="College_Name">College Name</asp:ListItem>
                            <asp:ListItem Value="Member_code">Member code</asp:ListItem>
        
                        </asp:DropDownList>
                        Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        <asp:Button CssClass="button" ID="btnNewEntry" runat="server" Text="New Entry" 
                            OnClick="btnNewEntry_Click" Width="84px" />
                        <asp:Button CssClass="button" ID="btnReport" runat="server" Text="Report" 
                            OnClick="btnReport_Click" Width="62px" />
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
                             <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("mem_id","~/LIBRARIAN/Member_entry.aspx?action=del&amp;id={0}") %>' Text="Delete"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("mem_id","~/LIBRARIAN/Member_entry.aspx?action=upd&amp;id={0}") %>' Text="Update"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Mem_id" HeaderText="Mem id" ReadOnly="True" 
                                    SortExpression="Mem_id" Visible="False" />
                                <asp:BoundField DataField="Member_Name" HeaderText="Member Name" 
                                    ReadOnly="True" SortExpression="Member_Name" />
                                <asp:BoundField DataField="Gender" HeaderText="Gender" 
                                    SortExpression="Gender" Visible="False" />
                                <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" />
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
                                    SortExpression="College_Name" Visible="False" />
                                <asp:BoundField DataField="Member_code" HeaderText="Member code" 
                                    SortExpression="Member_code" Visible="False" />
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
