<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    <asp:Label ID="CountLabel" runat="server" Font-Size="Medium"/>
        <br />
        <asp:GridView ID="GridView1" runat="server"
                      DataKeyNames="UserName" AutoGenerateColumns="false" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
            onrowdeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="Имя пользователя"/>
                <asp:BoundField DataField="Email" HeaderText="Email"/>
                <asp:BoundField DataField="CreationDate" HeaderText="Зарегистрирован"/>
                <asp:CommandField ShowSelectButton="true"/>
                <asp:CommandField ShowDeleteButton="true"/>
            </Columns>
        </asp:GridView>
        <br/>
        Selected user:<br/>
        <table style="border: 1px solid blue">
            <tr>
                <td>User name:</td>
                <td>
                    <asp:Label ID="UsernameLabel" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="EmailText" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>Password: </td>
                <td>
                    <asp:TextBox ID="PasswordText" runat="server"/>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="update_btn" runat="server" OnClick="update_btn_Click" Text="Update" />
    </div>
</asp:Content>
