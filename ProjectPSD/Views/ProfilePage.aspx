<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="ProjectPSD.Views.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="usernameTB" Enabled="false" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="emailTB" Enabled="false" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender :"></asp:Label>
            <asp:TextBox ID="genderTB" Enabled="false" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Date of Birth :"></asp:Label>
            <asp:TextBox ID="DOBTB" Enabled="false" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="editBtn" OnClick="editBtn_Click" runat="server" Text="Edit Profile" />
            <asp:Button ID="cPassBtn" OnClick="cPassBtn_Click" runat="server" Text="Change Password" />
        </div>
        <div ID="changePass" style="display:none;" runat="server">
            <div>
                <asp:Label ID="Label5" runat="server" Text="Current Password :"></asp:Label>
                <asp:TextBox ID="currPass" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="New Password :"></asp:Label>
                <asp:TextBox ID="newPass" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="savePass" OnClick="savePass_Click" runat="server" Text="Save New Password" />
            <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="back" OnClick="back_Click" runat="server" Text="Back" />
    </form>
</body>
</html>
