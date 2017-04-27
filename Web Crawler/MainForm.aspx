<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebCrawler.MainForm" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="WebCrawler" runat="server">
    <title>Web Crawler</title>
    <style type="text/css">
        div 
        {
            margin:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <h3>Not The Onion</h3>
                <p>
                    <asp:TextBox ID="SearchInput" runat="server" Width="446px"></asp:TextBox>
                </p>
                <asp:RadioButtonList ID="AlgoSelection" runat="server">
                    <asp:ListItem Text="KMP" Value="KMP"></asp:ListItem>
                    <asp:ListItem Text="Boyer-Moore" Value="Boyer-Moore"></asp:ListItem>
                    <asp:ListItem Text="Regex" Value="Regex"></asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="SearchButton" runat="server" Text="Search" onclick="ButtonClick" Width="120px"/>

                <div>
                    <br>
                    <asp:Label ID="contentHasilPencarian" runat="server"></asp:Label>
                    <asp:LinkButton ID="about" runat="server" CssClass="clickLabel" OnClick="AboutClick">About</asp:LinkButton>
                </div>
                <span runat="server" id="changed_text" />
            </fieldset>
        </div>
    </form>
</body>
</html>
