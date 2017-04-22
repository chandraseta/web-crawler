<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebCrawler.MainForm" %>

<!-- code section-->
<script runat="server">
private void ButtonClick(object sender, EventArgs e)
{
    string buf = TextBox1.Text;
    changed_text.InnerHtml = buf.ToUpper();
}
</script>

<!--layout-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change to upper case</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="WebApp"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Masukkan input"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Menggunakan algoritma:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>KMP</asp:ListItem>
            <asp:ListItem>Boyer-Moore</asp:ListItem>
            <asp:ListItem>Regex</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Search" onclick="ButtonClick"/>
        <h3>Result:</h3>
        <span runat="server" id="changed_text" />
    </form>
</body>
</html>
