<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Performance._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 250px;
            height: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="Contrator  Logo" class="auto-style1" src="employee-contract-logo.png" /><br />
        <h2>Contractor Performance Tracker</h2>
        Contractor Name:&nbsp;
        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        <br />
        Number of projects:&nbsp;
        <asp:TextBox ID="projectBox" runat="server"></asp:TextBox>
        <br />
        Average rating of projects performed:&nbsp;
        <asp:TextBox ID="ratingBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
