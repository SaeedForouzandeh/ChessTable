<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChessBoardApp.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>صفحه اصلی</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="containerPage">
        <h1>جدول شطرنجی بسازید</h1>
        <form id="form1" runat="server">
            <asp:TextBox ID="txtRows" runat="server" Placeholder="تعداد سطرها"></asp:TextBox><br />
            <asp:TextBox ID="txtColumns" runat="server" Placeholder="تعداد ستون‌ها"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="ایجاد جدول" OnClick="btnSubmit_Click" />
        </form>
    </div>
</body>
</html>
