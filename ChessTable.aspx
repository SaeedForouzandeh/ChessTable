<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChessTable.aspx.cs" Inherits="ChessBoardApp.ChessTable" %>

<!DOCTYPE html>
<html lang="fa">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>جدول شطرنج</title>
    <!-- لینک به فایل استایل -->
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="container">
        <h1>جدول شطرنج</h1>
        <!-- نمایش اطلاعات جدول -->
        <asp:Label ID="lblTableInfo" runat="server" CssClass="info-label"></asp:Label>
        <br /><br />
        <!-- جایگاه نمایش جدول -->
        <asp:PlaceHolder ID="TablePlaceholder" runat="server"></asp:PlaceHolder>
        <br />
        <!-- دکمه بازگشت به صفحه اصلی -->
        <button onclick="window.location.href='Default.aspx';" class="btn">بازگشت به صفحه اصلی</button>
    </div>
</body>
</html>
