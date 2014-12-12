<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Accession_list.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm2" %>
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
                            Accession List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>


                        <asp:Label ID="Label3" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="acc_id">Acc id</asp:ListItem>
                            <asp:ListItem Value="Title">Title</asp:ListItem>
                            <asp:ListItem Value="Author">Author</asp:ListItem>
                            <asp:ListItem Value="Book_type">Book type</asp:ListItem>
                            <asp:ListItem Value="Edition">Edition</asp:ListItem>
                            <asp:ListItem Value="Acc_code">Acc code</asp:ListItem>
                            <asp:ListItem Value="Location"></asp:ListItem>
                            <asp:ListItem Value="College_Name">College Name</asp:ListItem>
        
                            <asp:ListItem Value="Is_issue">Is issue</asp:ListItem>
                            <asp:ListItem Value="Subject"></asp:ListItem>
                            <asp:ListItem Value="Book_id">Book id</asp:ListItem>
        
                        </asp:DropDownList>
                        Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button CssClass="button" ID="btnShow0" runat="server" Text="Show" 
                        OnClick="btnShow_Click" />
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
                               <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Acc_id","~/LIBRARIAN/Accession_entry.aspx?action=del&amp;id={0}") %>' Text="Delete"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                 <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("Acc_id","~/LIBRARIAN/Accession_entry.aspx?action=upd&amp;id={0}") %>' Text="Update"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:BoundField DataField="Acc_id" HeaderText="Acc id" 
                                    SortExpression="Acc_id" />
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" 
                                    SortExpression="Author" />
                                <asp:BoundField DataField="Book_type" HeaderText="Book type" 
                                    SortExpression="Book_type" />
                                <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                    SortExpression="Edition" />
                                <asp:BoundField DataField="Acc_code" HeaderText="Acc code" 
                                    SortExpression="Acc_code" />
                                <asp:BoundField DataField="Location" HeaderText="Location" 
                                    SortExpression="Location" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Is_issue" HeaderText="Is issue" 
                                    SortExpression="Is_issue" />
                                <asp:BoundField DataField="Status" HeaderText="Status" 
                                    SortExpression="Status" />
                                <asp:BoundField DataField="Subject" HeaderText="Subject" 
                                    SortExpression="Subject" />
                                <asp:BoundField DataField="Book_id" HeaderText="Book id" 
                                    SortExpression="Book_id" />
                                <asp:BoundField DataField="College_id" HeaderText="College_id" 
                                    SortExpression="College_id" Visible="False" />


                                <asp:TemplateField HeaderText="Photo">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Book_Img/" + Eval("photo") %>' Width="80px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
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
                            SelectCommand="SELECT * FROM [VAccession]"></asp:SqlDataSource>
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
