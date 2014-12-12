<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="E_lib_pro1.WebForm7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td colspan="3">
                    &nbsp;
                    &nbsp;
                    &nbsp;
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="Mem_id" DataSourceID="SqlDataSource3" 
                        EmptyDataText="There are no data records to display.">
                        <Columns>
                            <asp:BoundField DataField="Mem_id" HeaderText="Mem_id" InsertVisible="False" 
                                ReadOnly="True" SortExpression="Mem_id" />
                            <asp:BoundField DataField="Reg_id" HeaderText="Reg_id" 
                                SortExpression="Reg_id" />
                            <asp:BoundField DataField="Username" HeaderText="Username" 
                                SortExpression="Username" />
                            <asp:BoundField DataField="Password" HeaderText="Password" 
                                SortExpression="Password" />
                            <asp:BoundField DataField="F_name" HeaderText="F_name" 
                                SortExpression="F_name" />
                            <asp:BoundField DataField="L_name" HeaderText="L_name" 
                                SortExpression="L_name" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" 
                                SortExpression="Gender" />
                            <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" />
                            <asp:BoundField DataField="Address" HeaderText="Address" 
                                SortExpression="Address" />
                            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                            <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                            <asp:BoundField DataField="Mobile" HeaderText="Mobile" 
                                SortExpression="Mobile" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />
                            <asp:BoundField DataField="Des_id" HeaderText="Des_id" 
                                SortExpression="Des_id" />
                            <asp:BoundField DataField="Dep_id" HeaderText="Dep_id" 
                                SortExpression="Dep_id" />
                            <asp:BoundField DataField="College_id" HeaderText="College_id" 
                                SortExpression="College_id" />
                            <asp:BoundField DataField="Member_code" HeaderText="Member_code" 
                                SortExpression="Member_code" />
                            <asp:BoundField DataField="Status" HeaderText="Status" 
                                SortExpression="Status" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:Library201000ConnectionString %>" 
                        ProviderName="<%$ ConnectionStrings:Library201000ConnectionString.ProviderName %>" 
                        SelectCommand="SELECT * FROM [Member]"></asp:SqlDataSource>
                    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                        DataFile="C:\Users\Admin\Desktop\Library201000.mdb" 
                        DeleteCommand="DELETE FROM `Member` WHERE `Mem_id` = ?" 
                        InsertCommand="INSERT INTO `Member` (`Mem_id`, `Reg_id`, `Username`, `Password`, `F_name`, `L_name`, `Gender`, `Dob`, `Address`, `City`, `Phone`, `Role`, `Mobile`, `Email`, `Photo`, `Des_id`, `Dep_id`, `College_id`, `Member_code`, `Status`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" 
                        SelectCommand="SELECT `Mem_id`, `Reg_id`, `Username`, `Password`, `F_name`, `L_name`, `Gender`, `Dob`, `Address`, `City`, `Phone`, `Role`, `Mobile`, `Email`, `Photo`, `Des_id`, `Dep_id`, `College_id`, `Member_code`, `Status` FROM `Member`" 
                        UpdateCommand="UPDATE `Member` SET `Reg_id` = ?, `Username` = ?, `Password` = ?, `F_name` = ?, `L_name` = ?, `Gender` = ?, `Dob` = ?, `Address` = ?, `City` = ?, `Phone` = ?, `Role` = ?, `Mobile` = ?, `Email` = ?, `Photo` = ?, `Des_id` = ?, `Dep_id` = ?, `College_id` = ?, `Member_code` = ?, `Status` = ? WHERE `Mem_id` = ?">
                        <DeleteParameters>
                            <asp:Parameter Name="Mem_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Mem_id" Type="Int32" />
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Username" Type="String" />
                            <asp:Parameter Name="Password" Type="String" />
                            <asp:Parameter Name="F_name" Type="String" />
                            <asp:Parameter Name="L_name" Type="String" />
                            <asp:Parameter Name="Gender" Type="String" />
                            <asp:Parameter Name="Dob" Type="DateTime" />
                            <asp:Parameter Name="Address" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Phone" Type="String" />
                            <asp:Parameter Name="Role" Type="String" />
                            <asp:Parameter Name="Mobile" Type="Int32" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                            <asp:Parameter Name="Des_id" Type="Int32" />
                            <asp:Parameter Name="Dep_id" Type="Int32" />
                            <asp:Parameter Name="College_id" Type="Int32" />
                            <asp:Parameter Name="Member_code" Type="String" />
                            <asp:Parameter Name="Status" Type="Int32" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Username" Type="String" />
                            <asp:Parameter Name="Password" Type="String" />
                            <asp:Parameter Name="F_name" Type="String" />
                            <asp:Parameter Name="L_name" Type="String" />
                            <asp:Parameter Name="Gender" Type="String" />
                            <asp:Parameter Name="Dob" Type="DateTime" />
                            <asp:Parameter Name="Address" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Phone" Type="String" />
                            <asp:Parameter Name="Role" Type="String" />
                            <asp:Parameter Name="Mobile" Type="Int32" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                            <asp:Parameter Name="Des_id" Type="Int32" />
                            <asp:Parameter Name="Dep_id" Type="Int32" />
                            <asp:Parameter Name="College_id" Type="Int32" />
                            <asp:Parameter Name="Member_code" Type="String" />
                            <asp:Parameter Name="Status" Type="Int32" />
                            <asp:Parameter Name="Mem_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:AccessDataSource>
                </td>
            </tr>
            
            <tr>
                <td colspan="3">
                    &nbsp;
                    &nbsp;
                    &nbsp;
                    <asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" DataKeyNames="Mem_id" DataSourceID="SqlDataSource2" 
                        EmptyDataText="There are no data records to display.">
                        <Columns>
                            <asp:BoundField DataField="Mem_id" HeaderText="Mem_id" ReadOnly="True" 
                                SortExpression="Mem_id" />
                            <asp:BoundField DataField="Reg_id" HeaderText="Reg_id" 
                                SortExpression="Reg_id" />
                            <asp:BoundField DataField="Username" HeaderText="Username" 
                                SortExpression="Username" />
                            <asp:BoundField DataField="Password" HeaderText="Password" 
                                SortExpression="Password" />
                            <asp:BoundField DataField="F_name" HeaderText="F_name" 
                                SortExpression="F_name" />
                            <asp:BoundField DataField="L_name" HeaderText="L_name" 
                                SortExpression="L_name" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" 
                                SortExpression="Gender" />
                            <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" />
                            <asp:BoundField DataField="Address" HeaderText="Address" 
                                SortExpression="Address" />
                            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                            <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                            <asp:BoundField DataField="Mobile" HeaderText="Mobile" 
                                SortExpression="Mobile" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />
                            <asp:BoundField DataField="Des_id" HeaderText="Des_id" 
                                SortExpression="Des_id" />
                            <asp:BoundField DataField="Dep_id" HeaderText="Dep_id" 
                                SortExpression="Dep_id" />
                            <asp:BoundField DataField="College_id" HeaderText="College_id" 
                                SortExpression="College_id" />
                            <asp:BoundField DataField="Member_code" HeaderText="Member_code" 
                                SortExpression="Member_code" />
                            <asp:BoundField DataField="Status" HeaderText="Status" 
                                SortExpression="Status" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        SelectCommand="SELECT * FROM [Member]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        DeleteCommand="DELETE FROM [Member] WHERE [Mem_id] = @Mem_id" 
                        InsertCommand="INSERT INTO [Member] ([Mem_id], [Reg_id], [Username], [Password], [F_name], [L_name], [Gender], [Dob], [Address], [City], [Phone], [Role], [Mobile], [Email], [Photo], [Des_id], [Dep_id], [College_id], [Member_code], [Status]) VALUES (@Mem_id, @Reg_id, @Username, @Password, @F_name, @L_name, @Gender, @Dob, @Address, @City, @Phone, @Role, @Mobile, @Email, @Photo, @Des_id, @Dep_id, @College_id, @Member_code, @Status)" 
                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                        SelectCommand="SELECT [Mem_id], [Reg_id], [Username], [Password], [F_name], [L_name], [Gender], [Dob], [Address], [City], [Phone], [Role], [Mobile], [Email], [Photo], [Des_id], [Dep_id], [College_id], [Member_code], [Status] FROM [Member]" 
                        UpdateCommand="UPDATE [Member] SET [Reg_id] = @Reg_id, [Username] = @Username, [Password] = @Password, [F_name] = @F_name, [L_name] = @L_name, [Gender] = @Gender, [Dob] = @Dob, [Address] = @Address, [City] = @City, [Phone] = @Phone, [Role] = @Role, [Mobile] = @Mobile, [Email] = @Email, [Photo] = @Photo, [Des_id] = @Des_id, [Dep_id] = @Dep_id, [College_id] = @College_id, [Member_code] = @Member_code, [Status] = @Status WHERE [Mem_id] = @Mem_id">
                        <DeleteParameters>
                            <asp:Parameter Name="Mem_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Mem_id" Type="Int32" />
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Username" Type="String" />
                            <asp:Parameter Name="Password" Type="String" />
                            <asp:Parameter Name="F_name" Type="String" />
                            <asp:Parameter Name="L_name" Type="String" />
                            <asp:Parameter Name="Gender" Type="String" />
                            <asp:Parameter Name="Dob" Type="DateTime" />
                            <asp:Parameter Name="Address" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Phone" Type="String" />
                            <asp:Parameter Name="Role" Type="String" />
                            <asp:Parameter Name="Mobile" Type="Decimal" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                            <asp:Parameter Name="Des_id" Type="Int32" />
                            <asp:Parameter Name="Dep_id" Type="Int32" />
                            <asp:Parameter Name="College_id" Type="Int32" />
                            <asp:Parameter Name="Member_code" Type="String" />
                            <asp:Parameter Name="Status" Type="Int32" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Username" Type="String" />
                            <asp:Parameter Name="Password" Type="String" />
                            <asp:Parameter Name="F_name" Type="String" />
                            <asp:Parameter Name="L_name" Type="String" />
                            <asp:Parameter Name="Gender" Type="String" />
                            <asp:Parameter Name="Dob" Type="DateTime" />
                            <asp:Parameter Name="Address" Type="String" />
                            <asp:Parameter Name="City" Type="String" />
                            <asp:Parameter Name="Phone" Type="String" />
                            <asp:Parameter Name="Role" Type="String" />
                            <asp:Parameter Name="Mobile" Type="Decimal" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                            <asp:Parameter Name="Des_id" Type="Int32" />
                            <asp:Parameter Name="Dep_id" Type="Int32" />
                            <asp:Parameter Name="College_id" Type="Int32" />
                            <asp:Parameter Name="Member_code" Type="String" />
                            <asp:Parameter Name="Status" Type="Int32" />
                            <asp:Parameter Name="Mem_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
