<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectPSD.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="passwordTB" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="rememberCB" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
        </div>
        <div>
            <asp:Button ID="loginBtn" OnClick="loginBtn_Click" runat="server" Text="Log In" />
            <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="reg" runat="server" Text="Dont have account ? "></asp:Label>
            <asp:Button ID="RegBtn" OnClick="RegBtn_Click" runat="server" Text="Register Here" />
        </div>
        
    </form>
</body>
</html>
