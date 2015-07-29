<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebPart2Task.Contact" %>

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
        <hgroup class="title">
            <h2>Your contact page.</h2>
        </hgroup>

        <section class="contact">
            <header>
                <h3>Phone:</h3>
            </header>
            <p>
                <span class="label">Main:</span>
                <span>425.555.0100</span>
            </p>
            <p>
                <span class="label">After Hours:</span>
                <span>425.555.0199</span>
            </p>
        </section>

        <section class="contact">
            <header>
                <h3>Email:</h3>
            </header>
            <p>
                <span class="label">Support:</span>
                <span><a href="mailto:Support@example.com">Support@example.com</a></span>
            </p>
            <p>
                <span class="label">Marketing:</span>
                <span><a href="mailto:Marketing@example.com">Marketing@example.com</a></span>
            </p>
            <p>
                <span class="label">General:</span>
                <span><a href="mailto:General@example.com">General@example.com</a></span>
            </p>
        </section>

        <section class="contact">
            <header>
                <h3>Address:</h3>
            </header>
            <p>
                One Microsoft Way<br/>
                Redmond, WA 98052-6399
            </p>
        </section>
    </div>
</form>
</body>
</html>
