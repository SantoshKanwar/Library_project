<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Book_Issue_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.Book_Issue_entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table>
        <tr>
            <td colspan="7" align="center">
                <h2>Book Issue Entry 
                    <asp:Label ID="lblReg_ID" runat="server" Visible="False"></asp:Label>
                </h2>
                <p> 
                    &nbsp;
                    <h4><asp:Label ID="lblcollegeid" runat="server" Text="lblcollegeid" Visible="False"></asp:Label></h4>
                <h4><asp:Label ID="lblcollegename" runat="server" Text="lblcollegename" 
                        Font-Bold="True" Font-Size="Larger"></asp:Label></h4></p>
</td>
            <td align="center">
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                &nbsp;</td>
            <td  >
                <asp:Label ID="lblRole" runat="server" Font-Bold="True" Visible="False"></asp:Label>
             </td>
            <td  >
                &nbsp;</td>
            <td colspan="2" style="text-decoration:blink">
                <asp:Label ID="lblMax" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF6600"></asp:Label>
             </td>

                 <td>
                     Issue Date</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
             </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <b>Student &amp; Staff Detail</b></td>
            <td>
                <asp:Label ID="lblMem_Id" runat="server" Font-Bold="True" Visible="False"></asp:Label>
             </td>
            <td rowspan="5">
            
               <asp:Image ID="Image1"  runat="server" Height="130px" Width="100px" />
               
            </td>
            <td rowspan="5">
                <asp:Image ID="Image2" runat="server" Height="130px" Width="100px" />
            </td>
            <td>
                <asp:Label ID="lblAcc_ID" runat="server" Font-Bold="True" Visible="False"></asp:Label>
             </td>
            
            
            <td>
               <b> Book Detail</b></td>
            
            
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Enrollment No"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;
                </td>
            <td valign="top">
                <asp:Button ID="Button4" CssClass="button" runat="server" Text="Show" 
                    onclick="Button4_Click" />
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Accession Code"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox12"  runat="server"></asp:TextBox>
            </td>
            <td valign="top">
                <asp:Button ID="Button5" runat="server" CssClass="button" 
                    onclick="Button5_Click" Text="Show" />
                </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                        <asp:Button ID="Button2" CssClass="button" runat="server" Text="Report" 
                    onclick="btnReport_Click" />
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Title"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Author"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="College"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Subject"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
                Issue Days:<asp:TextBox ID="TextBox8" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp; Due Date:
                <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Maximum Book Is Issue&nbsp;
                <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
                <asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Bir_id" DataSourceID="SqlDataSource3" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" 
                   >
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Bir_id","~/LIBRARIAN/Book_Issue_entry.aspx?did={0}") %>' Text="Delete"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Bir_id" HeaderText="Bir ID" ReadOnly="True" 
                            SortExpression="Bir_id" />
                        <asp:BoundField DataField="Acc_code" HeaderText="Acc Code" 
                            SortExpression="Acc_code" />
                        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                        <asp:BoundField DataField="Author" HeaderText="Author" 
                            SortExpression="Author" />
                        <asp:BoundField DataField="Book_type" HeaderText="Book Type" 
                            SortExpression="Book_type" />
                        <asp:BoundField DataField="Issue_dt" HeaderText="Issue Date" 
                            SortExpression="Issue_dt" />
                        <asp:BoundField DataField="due_dt" HeaderText="Return Date" 
                            SortExpression="due_dt" />
                        <asp:TemplateField HeaderText="Photo">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                       
                                       <asp:Image ID="Image1" ImageUrl='<%#"~/Book_Img/" + Eval("photo") %>' runat="server" Width="80px" />
                                    </ItemTemplate>
                        </asp:TemplateField>
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
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT Bir_id, Acc_code, Title, Author, Book_type, Issue_dt,due_dt, Photo FROM VBook_Issue_Return WHERE (Is_return = 0) AND (Mem_id = 0)">
                       
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
                <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
                <asp:Button ID="Button1"  CssClass="button" runat="server" Visible="false" Text="Issue" 
                    onclick="Button1_Click1"  />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Cancel"  CssClass="button" 
                    onclick="Button3_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </center>
</asp:Content>
