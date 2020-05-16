<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Contractor._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
            height: 231px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="Employee Contactor Name Logo" class="auto-style1" src="employee-contract-logo.png" /></div>
        <h1 style="font-family: Arial, Helvetica, sans-serif">Contractor Assignment Form</h1>
        <p style="font-family: Arial, Helvetica, sans-serif">
            Contractor Code Name:&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server" OnTextChanged="nameTextBox_TextChanged"></asp:TextBox>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            New Assignment Name:&nbsp; <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            End Date of Previous Assignment:
            <asp:Calendar ID="previousCalendar" runat="server" OnSelectionChanged="previousCalendar_SelectionChanged"></asp:Calendar>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            Start Date of New Assignment:
            <asp:Calendar ID="startCalendar" runat="server" OnSelectionChanged="startCalendar_SelectionChanged"></asp:Calendar>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            Projected End Date of New Assignment:
            <asp:Calendar ID="endCalendar" runat="server" OnSelectionChanged="endCalendar_SelectionChanged"></asp:Calendar>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign contractor" />
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
