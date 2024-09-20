<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileEditPage.aspx.cs" Inherits="ProjectPSD.Views.ProfileEditPage" %>

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
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Calendar ID="DOB" runat="server"></asp:Calendar>
                    <asp:Label ID="SelectedDateLabel" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div>
            <asp:Button ID="saveBtn" onclick="saveBtn_Click" runat="server" Text="Save" />
            <asp:Label ID="errMsg" runat="server" Text=""/>
        </div>
    </form>
</body>
</html>
