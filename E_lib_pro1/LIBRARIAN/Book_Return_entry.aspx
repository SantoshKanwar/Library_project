<%@ Page Title="" Language="C#" MasterPageFile="~/LIBRARIAN/Librian.Master" AutoEventWireup="true" CodeBehind="Book_Return_entry.aspx.cs" Inherits="E_lib_pro1.LIBRARIAN.Book_Return_entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .style2
        {
            height: 27px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table>
        <tr>
            <td colspan="6">
                 <h2>&nbsp;Book Return Entry 
                     <asp:Label ID="lblReg_ID" runat="server" Visible="False"></asp:Label>
                 </h2></td>
        </tr>
        <tr>
            <td colspan="6" align="center">
                 <b>
                <asp:Label ID="lblCollege_ID" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblcollegename" runat="server" Font-Bold="True" 
                     Font-Size="Larger"></asp:Label>
                 </b>
                 <asp:Button ID="Button4" runat="server" CssClass="button" ForeColor="White" 
                     onclick="btnReport" Text="Report" />
            </td>
        </tr>
        <tr>
            <td  colspan="2" class="style2">
               <b> Book</b></td>
            <td  rowspan="7">
                <asp:Image ID="Image2" runat="server" Height="150px" Width="100px" />
            </td>
            <td  rowspan="7">
                <asp:Image ID="Image1" runat="server" Height="150px" Width="100px" />
            </td>
            <td  colspan="2" class="style2">
                <b>
                &nbsp;<asp:Label ID="lblRole" 
                    runat="server" Visible="False"></asp:Label>
                Student &amp; Staff</b></td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label1" runat="server" Text="Accession code"></asp:Label>
            </td>
            <td >
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="Acc_code" 
                    DataValueField="Bir_id" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged"
                    >
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT Bir_id, Acc_code, Is_return FROM VBook_Issue_Return WHERE (Is_return = 0)">
                </asp:SqlDataSource>
                <asp:Label ID="lblAccID" runat="server" Visible="False"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label5" runat="server" Text="Enrollment No"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" 
                    DataSourceID="SqlDataSource2" DataTextField="Member_code" 
                    DataValueField="Mem_id" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT [Mem_id], [Member_code] FROM [Member]">
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Subject"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="college"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label10" runat="server" Text="Book Type"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Total  Fine" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" ForeColor="Red"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblTotDay" runat="server"></asp:Label>
            </td>
                 <td>
                &nbsp;</td>
          
          <tr>
            <td >
                Issue Date</td>
            <td>
                <asp:Label ID="lblIssue_Dt" runat="server" Text="Label" ForeColor="Red"></asp:Label>
              </td>
            <td>
                Return Date</td>
            <td>
                <asp:Label ID="lblReturnDt" runat="server" Text="Label" ForeColor="Red"></asp:Label>
              </td>
              <td>
                Due Date</td>
                <td>
                <asp:Label ID="lblDueDt" runat="server" Text="Label" ForeColor="Red"></asp:Label>
              </td>
                <td>
                &nbsp;</td>
        </tr>
          
          <tr>
            <td >
                Issue Day :</td>
            <td>
                <asp:Label ID="lblIssueDay" runat="server" Text="Label" ForeColor="Red"></asp:Label>
              </td>
            <td>
                Fine </td>
            <td>
                <asp:Label ID="lblFinePer_Day" runat="server" ForeColor="Red"></asp:Label>
              </td>
              <td>
                  &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Bir_id" DataSourceID="SqlDataSource3" 
                   >
                    <Columns>
                        <asp:BoundField DataField="Bir_id" HeaderText="Bir_id" ReadOnly="True" 
                            SortExpression="Bir_id" />
                        <asp:BoundField DataField="Acc_code" HeaderText="Acc_code" 
                            SortExpression="Acc_code" />
                        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                        <asp:BoundField DataField="Author" HeaderText="Author" 
                            SortExpression="Author" />
                        <asp:BoundField DataField="Book_type" HeaderText="Book_type" 
                            SortExpression="Book_type" />
                        <asp:BoundField DataField="Issue_dt" HeaderText="Issue_dt" 
                            SortExpression="Issue_dt" />
                        <asp:BoundField DataField="Return_dt" HeaderText="Return_dt" 
                            SortExpression="Return_dt" />
                        <asp:TemplateField HeaderText="Photo">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                       
                                       <asp:Image ID="Image3" ImageUrl='<%#"~/Book_img/" + Eval("photo") %>' runat="server" 
                                           Width="80px" />
                                    </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT Bir_id, Acc_code, Title, Author, Book_type, Issue_dt, Return_dt, Photo FROM VBook_Issue_Return WHERE (Is_return = 0) AND (Mem_id = @id)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="id" 
                            PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Button ID="Button1" runat="server" Text="Return" 
                    onclick="Button1_Click"  CssClass="button"/>
                <asp:Button ID="Button3" runat="server" CssClass="button" Text="Close" 
                    onclick="Button3_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </center>
</asp:Content>
