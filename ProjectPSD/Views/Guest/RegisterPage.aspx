<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectPSD.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="emailTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender :"></asp:Label>
            <asp:RadioButtonList ID="GenderRBL" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="passwordTB" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Confirm Password :"></asp:Label>
            <asp:TextBox ID="cfPasswordTB" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Calendar ID="DOB" runat="server"></asp:Calendar>
                    <asp:Label ID="SelectedDateLabel" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div>
            <asp:Button ID="register" OnClick="register_Click" runat="server" Text="Register" />
            <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Have an account? "></asp:Label>
            <asp:Button ID="toLogin" OnClick="toLogin_Click" runat="server" Text="Login" />
        </div>
        
    </form>
</body>
</html>
