<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stats.aspx.cs" Inherits="weblabexam.Stats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Feedback Statistics</h2>
            <asp:Label ID="lbltotal_Submissions" runat="server" Text="Total Submissions: "></asp:Label>
            <br />
            <asp:Label ID="lblLast_StudentName" runat="server" Text="Last Student Name: "></asp:Label>
            <br />
            <asp:HyperLink ID="lnkAddFeedback" runat="server" NavigateUrl="~/AddFeedback.aspx">Add Feedback</asp:HyperLink>
            <asp:HyperLink ID="lnkViewFeedback" runat="server" NavigateUrl="~/ViewFeedback.aspx">View Feedback</asp:HyperLink>
        </div>
    </form>
</body>
</html>
