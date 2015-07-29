<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebPart2Task.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <ul>
            <li>
                <a runat="server" href="~/Default.aspx">Home</a>
            </li>
            <li>
                <a runat="server" href="~/About.aspx">About</a>
            </li>
            <li>
                <a runat="server" href="~/Contact.aspx">Contact</a>
            </li>
            <li>
                <a runat="server" href="~/Stat.aspx">Statistics</a>
            </li>
        </ul>

        <h2>Your app description page.</h2>
        <article>
            <p>
                Use this area to provide additional information.
            </p>

            <p>
                Use this area to provide additional information.
            </p>

            <p>
                Use this area to provide additional information.
            </p>
        </article>

        <aside>
            <h3>Aside Title</h3>
            <p>
                Use this area to provide additional information.
            </p>
        </aside>
    </div>
</form>
</body>
</html>
