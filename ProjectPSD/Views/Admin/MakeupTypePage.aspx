<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeupTypePage.aspx.cs" Inherits="ProjectPSD.Views.Admin.MakeupTypePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Makeup Type : "></asp:Label>
            <asp:TextBox ID="typeTB" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="backBtn" OnClick="backBtn_Click" runat="server" Text="Back" />
        <asp:Button ID="saveBtn" OnClick="saveBtn_Click" runat="server" Text="Save" />
        <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
