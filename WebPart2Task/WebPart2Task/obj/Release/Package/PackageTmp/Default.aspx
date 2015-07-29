<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPart2Task.Default" %>

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
        <section class="featured">
            <div class="content-wrapper">
                <hgroup class="title">
                    <h2>Modify this template to jump-start your ASP.NET application.</h2>
                </hgroup>
                <p>
                    To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                    The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                    If you have any questions about ASP.NET visit
                    <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
                </p>
            </div>
        </section>
        <h3>We suggest the following:</h3>
        <ol class="round">
            <li class="one">
                <h5>Getting Started</h5>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
                A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
                <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Learn more…</a>
            </li>
            <li class="two">
                <h5>Add NuGet packages and jump-start your coding</h5>
                NuGet makes it easy to install and update free libraries and tools.
                <a href="http://go.microsoft.com/fwlink/?LinkId=245147">Learn more…</a>
            </li>
            <li class="three">
                <h5>Find Web Hosting</h5>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
                <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a>
            </li>
        </ol>
    </div>
</form>
</body>
</html>
