<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_lib_pro1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
/* Circle Text Styles */
#outerCircleText {
/* Optional - DO NOT SET FONT-SIZE HERE, SET IT IN THE SCRIPT */
font-style: italic;
font-weight: bold;
font-family: 'comic sans ms', verdana, arial;
color: #000;
/* End Optional */

/* Start Required - Do Not Edit */
position: absolute;top: 0;left: 0;z-index: 3000;cursor: default;}
#outerCircleText div {position: relative;}
#outerCircleText div div {position: absolute;top: 0;left: 0;text-align: center;}
/* End Required */
/* End Circle Text Styles */
</style>
<script type="text/javascript">

    /* Circling text trail- Tim Tilton
    Website: http://www.tempermedia.com/
    Visit: http://www.dynamicdrive.com/ for Original Source and tons of scripts
    Modified Here for more flexibility and modern browser support
    Modifications as first seen in http://www.dynamicdrive.com/forums/
    username:jscheuer1 - This notice must remain for legal use
    */

    ; (function () {

        // Your message here (QUOTED STRING)
        var msg = "E-LibPro";

        /* THE REST OF THE EDITABLE VALUES BELOW ARE ALL UNQUOTED NUMBERS */

        // Set font's style size for calculating dimensions
        // Set to number of desired pixels font size (decimal and negative numbers not allowed)
        var size = 24;

        // Set both to 1 for plain circle, set one of them to 2 for oval
        // Other numbers & decimals can have interesting effects, keep these low (0 to 3)
        var circleY = 0.75; var circleX = 2;

        // The larger this divisor, the smaller the spaces between letters
        // (decimals allowed, not negative numbers)
        var letter_spacing = 5;

        // The larger this multiplier, the bigger the circle/oval
        // (decimals allowed, not negative numbers, some rounding is applied)
        var diameter = 10;

        // Rotation speed, set it negative if you want it to spin clockwise (decimals allowed)
        var rotation = 0.4;

        // This is not the rotation speed, its the reaction speed, keep low!
        // Set this to 1 or a decimal less than one (decimals allowed, not negative numbers)
        var speed = 0.3;

        ////////////////////// Stop Editing //////////////////////

        if (!window.addEventListener && !window.attachEvent || !document.createElement) return;

        msg = msg.split('');
        var n = msg.length - 1, a = Math.round(size * diameter * 0.208333), currStep = 20,
ymouse = a * circleY + 20, xmouse = a * circleX + 20, y = [], x = [], Y = [], X = [],
o = document.createElement('div'), oi = document.createElement('div'),
b = document.compatMode && document.compatMode != "BackCompat" ? document.documentElement : document.body,

mouse = function (e) {
    e = e || window.event;
    ymouse = !isNaN(e.pageY) ? e.pageY : e.clientY; // y-position
    xmouse = !isNaN(e.pageX) ? e.pageX : e.clientX; // x-position
},

makecircle = function () { // rotation/positioning
    if (init.nopy) {
        o.style.top = (b || document.body).scrollTop + 'px';
        o.style.left = (b || document.body).scrollLeft + 'px';
    };
    currStep -= rotation;
    for (var d, i = n; i > -1; --i) { // makes the circle
        d = document.getElementById('iemsg' + i).style;
        d.top = Math.round(y[i] + a * Math.sin((currStep + i) / letter_spacing) * circleY - 15) + 'px';
        d.left = Math.round(x[i] + a * Math.cos((currStep + i) / letter_spacing) * circleX) + 'px';
    };
},

drag = function () { // makes the resistance
    y[0] = Y[0] += (ymouse - Y[0]) * speed;
    x[0] = X[0] += (xmouse - 20 - X[0]) * speed;
    for (var i = n; i > 0; --i) {
        y[i] = Y[i] += (y[i - 1] - Y[i]) * speed;
        x[i] = X[i] += (x[i - 1] - X[i]) * speed;
    };
    makecircle();
},

init = function () { // appends message divs, & sets initial values for positioning arrays
    if (!isNaN(window.pageYOffset)) {
        ymouse += window.pageYOffset;
        xmouse += window.pageXOffset;
    } else init.nopy = true;
    for (var d, i = n; i > -1; --i) {
        d = document.createElement('div'); d.id = 'iemsg' + i;
        d.style.height = d.style.width = a + 'px';
        d.appendChild(document.createTextNode(msg[i]));
        oi.appendChild(d); y[i] = x[i] = Y[i] = X[i] = 0;
    };
    o.appendChild(oi); document.body.appendChild(o);
    setInterval(drag, 25);
},

ascroll = function () {
    ymouse += window.pageYOffset;
    xmouse += window.pageXOffset;
    window.removeEventListener('scroll', ascroll, false);
};

        o.id = 'outerCircleText'; o.style.fontSize = size + 'px';

        if (window.addEventListener) {
            window.addEventListener('load', init, false);
            document.addEventListener('mouseover', mouse, false);
            document.addEventListener('mousemove', mouse, false);
            if (/Apple/.test(navigator.vendor))
                window.addEventListener('scroll', ascroll, false);
        }
        else if (window.attachEvent) {
            window.attachEvent('onload', init);
            document.attachEvent('onmousemove', mouse);
        };

    })();

</script>
    <style type="text/css">
        .style1
        {
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<br />
<br />
<br />

<table style="width: 100%;">
            <tr>
                <td colspan="3" class="style1">
                    &nbsp;
                    &nbsp;
                    &nbsp;
                    <%--<asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" DataKeyNames="Book_id" 
                        DataSourceID="AccessDataSource1" 
                        EmptyDataText="There are no data records to display.">
                        <Columns>
                            <asp:BoundField DataField="Book_id" HeaderText="Book_id" ReadOnly="True" 
                                SortExpression="Book_id" />
                            <asp:BoundField DataField="Reg_id" HeaderText="Reg_id" 
                                SortExpression="Reg_id" />
                            <asp:BoundField DataField="Pdate" HeaderText="Pdate" SortExpression="Pdate" />
                            <asp:BoundField DataField="Author" HeaderText="Author" 
                                SortExpression="Author" />
                            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                            <asp:BoundField DataField="Subject" HeaderText="Subject" 
                                SortExpression="Subject" />
                            <asp:BoundField DataField="Book_type" HeaderText="Book_type" 
                                SortExpression="Book_type" />
                            <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                SortExpression="Edition" />
                            <asp:BoundField DataField="Publisher_Place" HeaderText="Publisher_Place" 
                                SortExpression="Publisher_Place" />
                            <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                                SortExpression="Publisher" />
                            <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                            <asp:BoundField DataField="Pages" HeaderText="Pages" SortExpression="Pages" />
                            <asp:BoundField DataField="Volume" HeaderText="Volume" 
                                SortExpression="Volume" />
                            <asp:BoundField DataField="Source" HeaderText="Source" 
                                SortExpression="Source" />
                            <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                            <asp:BoundField DataField="Bill_no" HeaderText="Bill_no" 
                                SortExpression="Bill_no" />
                            <asp:BoundField DataField="Book_no" HeaderText="Book_no" 
                                SortExpression="Book_no" />
                            <asp:BoundField DataField="More_Info" HeaderText="More_Info" 
                                SortExpression="More_Info" />
                            <asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />
                        </Columns>
                    </asp:GridView>--%>
                    <%--<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                        DataFile="C:\Users\Admin\Desktop\Library201000.mdb" 
                        DeleteCommand="DELETE FROM `Book_Master` WHERE `Book_id` = ?" 
                        InsertCommand="INSERT INTO `Book_Master` (`Book_id`, `Reg_id`, `Pdate`, `Author`, `Title`, `Subject`, `Book_type`, `Edition`, `Publisher_Place`, `Publisher`, `Year`, `Pages`, `Volume`, `Source`, `Cost`, `Bill_no`, `Book_no`, `More_Info`, `Photo`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" 
                        SelectCommand="SELECT `Book_id`, `Reg_id`, `Pdate`, `Author`, `Title`, `Subject`, `Book_type`, `Edition`, `Publisher_Place`, `Publisher`, `Year`, `Pages`, `Volume`, `Source`, `Cost`, `Bill_no`, `Book_no`, `More_Info`, `Photo` FROM `Book_Master`" 
                        UpdateCommand="UPDATE `Book_Master` SET `Reg_id` = ?, `Pdate` = ?, `Author` = ?, `Title` = ?, `Subject` = ?, `Book_type` = ?, `Edition` = ?, `Publisher_Place` = ?, `Publisher` = ?, `Year` = ?, `Pages` = ?, `Volume` = ?, `Source` = ?, `Cost` = ?, `Bill_no` = ?, `Book_no` = ?, `More_Info` = ?, `Photo` = ? WHERE `Book_id` = ?">
                        <DeleteParameters>
                            <asp:Parameter Name="Book_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Book_id" Type="Int32" />
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Pdate" Type="DateTime" />
                            <asp:Parameter Name="Author" Type="String" />
                            <asp:Parameter Name="Title" Type="String" />
                            <asp:Parameter Name="Subject" Type="String" />
                            <asp:Parameter Name="Book_type" Type="String" />
                            <asp:Parameter Name="Edition" Type="String" />
                            <asp:Parameter Name="Publisher_Place" Type="String" />
                            <asp:Parameter Name="Publisher" Type="String" />
                            <asp:Parameter Name="Year" Type="Int32" />
                            <asp:Parameter Name="Pages" Type="Int32" />
                            <asp:Parameter Name="Volume" Type="String" />
                            <asp:Parameter Name="Source" Type="String" />
                            <asp:Parameter Name="Cost" Type="Decimal" />
                            <asp:Parameter Name="Bill_no" Type="Int32" />
                            <asp:Parameter Name="Book_no" Type="Int32" />
                            <asp:Parameter Name="More_Info" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Pdate" Type="DateTime" />
                            <asp:Parameter Name="Author" Type="String" />
                            <asp:Parameter Name="Title" Type="String" />
                            <asp:Parameter Name="Subject" Type="String" />
                            <asp:Parameter Name="Book_type" Type="String" />
                            <asp:Parameter Name="Edition" Type="String" />
                            <asp:Parameter Name="Publisher_Place" Type="String" />
                            <asp:Parameter Name="Publisher" Type="String" />
                            <asp:Parameter Name="Year" Type="Int32" />
                            <asp:Parameter Name="Pages" Type="Int32" />
                            <asp:Parameter Name="Volume" Type="String" />
                            <asp:Parameter Name="Source" Type="String" />
                            <asp:Parameter Name="Cost" Type="Decimal" />
                            <asp:Parameter Name="Bill_no" Type="Int32" />
                            <asp:Parameter Name="Book_no" Type="Int32" />
                            <asp:Parameter Name="More_Info" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                            <asp:Parameter Name="Book_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:AccessDataSource>--%>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp; </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;
                    &nbsp;
                    &nbsp;
                    <%--<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" DataKeyNames="Book_id" 
                        DataSourceID="SqlDataSource1" 
                        EmptyDataText="There are no data records to display.">
                        <Columns>
                            <asp:BoundField DataField="Book_id" HeaderText="Book_id" ReadOnly="True" 
                                SortExpression="Book_id" />
                            <asp:BoundField DataField="Reg_id" HeaderText="Reg_id" 
                                SortExpression="Reg_id" />
                            <asp:BoundField DataField="Pdate" HeaderText="Pdate" SortExpression="Pdate" />
                            <asp:BoundField DataField="Author" HeaderText="Author" 
                                SortExpression="Author" />
                            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                            <asp:BoundField DataField="Subject" HeaderText="Subject" 
                                SortExpression="Subject" />
                            <asp:BoundField DataField="Book_type" HeaderText="Book_type" 
                                SortExpression="Book_type" />
                            <asp:BoundField DataField="Edition" HeaderText="Edition" 
                                SortExpression="Edition" />
                            <asp:BoundField DataField="Publisher_place" HeaderText="Publisher_place" 
                                SortExpression="Publisher_place" />
                            <asp:BoundField DataField="Publisher" HeaderText="Publisher" 
                                SortExpression="Publisher" />
                            <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                            <asp:BoundField DataField="Pages" HeaderText="Pages" SortExpression="Pages" />
                            <asp:BoundField DataField="Volume" HeaderText="Volume" 
                                SortExpression="Volume" />
                            <asp:BoundField DataField="Source" HeaderText="Source" 
                                SortExpression="Source" />
                            <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
                            <asp:BoundField DataField="Bill_no" HeaderText="Bill_no" 
                                SortExpression="Bill_no" />
                            <asp:BoundField DataField="Book_no" HeaderText="Book_no" 
                                SortExpression="Book_no" />
                            <asp:BoundField DataField="More_info" HeaderText="More_info" 
                                SortExpression="More_info" />
                            <asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />
                        </Columns>
                    </asp:GridView>--%>
                    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                        DeleteCommand="DELETE FROM [Book_Master] WHERE [Book_id] = @Book_id" 
                        InsertCommand="INSERT INTO [Book_Master] ([Book_id], [Reg_id], [Pdate], [Author], [Title], [Subject], [Book_type], [Edition], [Publisher_place], [Publisher], [Year], [Pages], [Volume], [Source], [Cost], [Bill_no], [Book_no], [More_info], [Photo]) VALUES (@Book_id, @Reg_id, @Pdate, @Author, @Title, @Subject, @Book_type, @Edition, @Publisher_place, @Publisher, @Year, @Pages, @Volume, @Source, @Cost, @Bill_no, @Book_no, @More_info, @Photo)" 
                        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                        SelectCommand="SELECT [Book_id], [Reg_id], [Pdate], [Author], [Title], [Subject], [Book_type], [Edition], [Publisher_place], [Publisher], [Year], [Pages], [Volume], [Source], [Cost], [Bill_no], [Book_no], [More_info], [Photo] FROM [Book_Master]" 
                        UpdateCommand="UPDATE [Book_Master] SET [Reg_id] = @Reg_id, [Pdate] = @Pdate, [Author] = @Author, [Title] = @Title, [Subject] = @Subject, [Book_type] = @Book_type, [Edition] = @Edition, [Publisher_place] = @Publisher_place, [Publisher] = @Publisher, [Year] = @Year, [Pages] = @Pages, [Volume] = @Volume, [Source] = @Source, [Cost] = @Cost, [Bill_no] = @Bill_no, [Book_no] = @Book_no, [More_info] = @More_info, [Photo] = @Photo WHERE [Book_id] = @Book_id">
                        <DeleteParameters>
                            <asp:Parameter Name="Book_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Book_id" Type="Int32" />
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Pdate" Type="DateTime" />
                            <asp:Parameter Name="Author" Type="String" />
                            <asp:Parameter Name="Title" Type="String" />
                            <asp:Parameter Name="Subject" Type="String" />
                            <asp:Parameter Name="Book_type" Type="String" />
                            <asp:Parameter Name="Edition" Type="String" />
                            <asp:Parameter Name="Publisher_place" Type="String" />
                            <asp:Parameter Name="Publisher" Type="String" />
                            <asp:Parameter Name="Year" Type="Int32" />
                            <asp:Parameter Name="Pages" Type="Int32" />
                            <asp:Parameter Name="Volume" Type="String" />
                            <asp:Parameter Name="Source" Type="String" />
                            <asp:Parameter Name="Cost" Type="Decimal" />
                            <asp:Parameter Name="Bill_no" Type="Int32" />
                            <asp:Parameter Name="Book_no" Type="Int32" />
                            <asp:Parameter Name="More_info" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Reg_id" Type="Int32" />
                            <asp:Parameter Name="Pdate" Type="DateTime" />
                            <asp:Parameter Name="Author" Type="String" />
                            <asp:Parameter Name="Title" Type="String" />
                            <asp:Parameter Name="Subject" Type="String" />
                            <asp:Parameter Name="Book_type" Type="String" />
                            <asp:Parameter Name="Edition" Type="String" />
                            <asp:Parameter Name="Publisher_place" Type="String" />
                            <asp:Parameter Name="Publisher" Type="String" />
                            <asp:Parameter Name="Year" Type="Int32" />
                            <asp:Parameter Name="Pages" Type="Int32" />
                            <asp:Parameter Name="Volume" Type="String" />
                            <asp:Parameter Name="Source" Type="String" />
                            <asp:Parameter Name="Cost" Type="Decimal" />
                            <asp:Parameter Name="Bill_no" Type="Int32" />
                            <asp:Parameter Name="Book_no" Type="Int32" />
                            <asp:Parameter Name="More_info" Type="String" />
                            <asp:Parameter Name="Photo" Type="String" />
                            <asp:Parameter Name="Book_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>--%>
                </td>
            </tr>
        </table>

<br />
<br />
<br />
<br />
<br /></asp:Content>
