<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="weblabexam.AddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Student Name<asp:TextBox ID="SNametxt" runat="server" ></asp:TextBox>
        <br />
        Course Name<asp:TextBox ID="CNametxt" runat="server"></asp:TextBox>
        <br />
        Comments<asp:TextBox ID="Commenttxt" runat="server"></asp:TextBox>
        <br />
        Phone<asp:TextBox ID="Phonetxt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <br />
        </form>
        
</body>
</html>
