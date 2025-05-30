```aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="weblabexam.ViewFeedback" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Feedback</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="FeedbackID">
                <Columns>
                    <asp:BoundField DataField="FeedbackID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="StudentName" HeaderText="Student" ReadOnly="True" />
                    <asp:BoundField DataField="CourseName" HeaderText="Course" />
                    <asp:BoundField DataField="Comments" HeaderText="Comment" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" />
                </Columns>
            </asp:GridView>
            <br />
            Feedback ID: <asp:TextBox ID="txtFeedbackID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
            <a href="AddFeedback.aspx">Add Feedback</a> | 
            <a href="Stats.aspx">View Stats</a>
        </div>
    </form>
</body>
</html>
```