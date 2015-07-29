<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPart1Task.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Explanation about Page_Unload event and other methods which can`t be displayed with Response.Write() in comment"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Table ID="Table1" ToolTip="This is a table of Request.Form collection values!!!" GridLines="Both" HorizontalAlign="Center" Font-Names="Verdana" Font-Size="8pt" CellPadding="15" CellSpacing="0" runat="server"></asp:Table>
        <br />
        <br />
        <br />
    
        <asp:Button ID="Button1" runat="server" Text="Button For PostBack" OnClick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
