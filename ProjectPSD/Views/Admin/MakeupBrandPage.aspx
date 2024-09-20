<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeupBrandPage.aspx.cs" Inherits="ProjectPSD.Views.Admin.MakeupBrandPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Makeup Brand : "></asp:Label>
            <asp:TextBox ID="brandTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Brand Rating: "></asp:Label>
            <asp:TextBox ID="ratingTB" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="backBtn" OnClick="backBtn_Click" runat="server" Text="Back" />
        <asp:Button ID="saveBtn" OnClick="saveBtn_Click" runat="server" Text="Save" />
        <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
