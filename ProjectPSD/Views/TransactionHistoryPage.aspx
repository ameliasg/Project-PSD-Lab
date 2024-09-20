<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="ProjectPSD.Views.TransactionHistoryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="transactionGV" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
                <asp:BoundField DataField="User.UserName" HeaderText="User Name" SortExpression="User.UserName"></asp:BoundField>
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate"></asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status"></asp:BoundField>
                <asp:TemplateField HeaderText="Details">
                    <ItemTemplate>
                        <asp:Button ID="details" OnClick="details_Click" runat="server" Text="Details" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="back" OnClick="back_Click" runat="server" Text="Back"/>
    </form>
</body>
</html>
