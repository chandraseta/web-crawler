<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="Web_Crawler.MainForm2" %>

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
                <h3>Our Web Crawler Application</h3>
                <p>
                    <asp:Label ID="Label2" runat="server" Text="Masukkan input"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
                <asp:Label ID="Label3" runat="server" Text="Menggunakan algoritma:"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Text="KMP" Value="KMP"></asp:ListItem>
                    <asp:ListItem Text="Boyer-Moore" Value="Boyer-Moore"></asp:ListItem>
                    <asp:ListItem Text="Regex" Value="Regex"></asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="Button1" runat="server" Text="Search" onclick="ButtonClick"/>
                <h3>Pesan Kesalahan:</h3>
                <div>
                    <asp:Label ID="textTyped" runat="server"></asp:Label>
                    <br>
                    <asp:Label ID="buttonSelected" runat="server"></asp:Label>
                    <br>
                    <asp:Label ID="indexHasilPencarian" runat="server"></asp:Label>
                    <br>
                    <asp:Label ID="contentHasilPencarian" runat="server"></asp:Label>

                </div>


                <h3>Result:</h3>
                <div>
                    
                </div>
                <span runat="server" id="changed_text" />
            </fieldset>
        </div>
    </form>
</body>
</html>
