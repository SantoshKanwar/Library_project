<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Setting_List.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.WebForm26" %>
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
                            Setting List
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblResult" runat="server" Text="  "></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text="Label" 
                            style="font-size: larger; font-weight: 700"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Text="Label" 
                            style="font-weight: 700; font-size: larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Search On :
                        <asp:DropDownList ID="cboSearch" runat="server" Height="25px" Width="150px">
        
                            <asp:ListItem Value="set_id">Set id</asp:ListItem>
                            <asp:ListItem Value="reg_id">Reg id</asp:ListItem>
                            <asp:ListItem Value="mem_role">Mem role</asp:ListItem>
                            <asp:ListItem Value="due_day">Due day</asp:ListItem>
                            <asp:ListItem Value="total_book">Total book</asp:ListItem>
                            <asp:ListItem Value="fine_per_day">Fine per day</asp:ListItem>
        
                        </asp:DropDownList>
                        &nbsp;Search By :
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button CssClass="button" ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
                        &nbsp;<asp:Button Cssclass="button" ID="btnNewEntry" runat="server" Text="New Entry" 
                            onclick="btnNewEntry_Click" />
                            &nbsp;<asp:Button Cssclass="button" ID="btnReport" runat="server" Text="Report" 
                            onclick="btnReport_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="Set_id" DataSourceID="SqlDataSource1" 
                            EmptyDataText="There are no data records to display." AllowPaging="True" 
                            AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Set_id","~/LIBRARIAN/Setting_entry.aspx?action=del&amp;id={0}") %>' Text="Delete"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("Set_id","~/LIBRARIAN/Setting_entry.aspx?action=upd&amp;id={0}") %>' Text="Edit"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:BoundField DataField="Set_id" HeaderText="Setting id" ReadOnly="True" 
                                    SortExpression="Set_id" />
                                <asp:BoundField DataField="Reg_id" HeaderText="Registration id" 
                                    SortExpression="Reg_id" Visible="False" />
                                <asp:BoundField DataField="College_id" HeaderText="College id" 
                                    SortExpression="College_id" />
                                <asp:BoundField DataField="College_Name" HeaderText="College Name" 
                                    SortExpression="College_Name" />
                                <asp:BoundField DataField="Mem_role" HeaderText="Member role" 
                                    SortExpression="Mem_role" />
                                <asp:BoundField DataField="Due_day" HeaderText="Due day" 
                                    SortExpression="Due_day" />
                                <asp:BoundField DataField="Total_book" HeaderText="Total book" 
                                    SortExpression="Total_book" />
                                <asp:BoundField DataField="Fine_per_day" HeaderText="Fine per day" 
                                    SortExpression="Fine_per_day" />
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
                            SelectCommand="SELECT Set_id, Reg_id, College_id, College_Name, Mem_role, Due_day, Total_book, Fine_per_day FROM VSetting WHERE (College_id = @college_id)">
                            <SelectParameters>
                                <asp:SessionParameter Name="college_id" SessionField="college_id" />
                            </SelectParameters>
                        </asp:SqlDataSource>
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
