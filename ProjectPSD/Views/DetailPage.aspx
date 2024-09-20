<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="ProjectPSD.Views.DetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="TransactionID : "></asp:Label>
            <asp:Label ID="tID" runat="server" Text=""></asp:Label>
        </div>
        <asp:GridView ID="DetailGV" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup Name" SortExpression="Makeup.MakeupName"></asp:BoundField>
                <asp:BoundField DataField="Makeup.MakeupPrice" HeaderText="Makeup Price" SortExpression="Makeup.MakeupPrice"></asp:BoundField>
                <asp:BoundField DataField="Makeup.MakeupWeight" HeaderText="Makeup Weight" SortExpression="Makeup.MakeupWeight"></asp:BoundField>
                <asp:BoundField DataField="Makeup.MakeupType.MakeupTypeName" HeaderText="Makeup Type" SortExpression="Makeup.MakeupType.MakeupTypeName"></asp:BoundField>
                <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandName" HeaderText="Makeup Brand" SortExpression="Makeup.MakeupBrand.MakeupBrandName"></asp:BoundField>
                <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandRating" HeaderText="Makeup Brand Rating" SortExpression="Makeup.MakeupBrand.MakeupBrandRating"></asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
            </Columns>

        </asp:GridView>
        <asp:Button ID="back" OnClick="back_Click" runat="server" Text="Back" />
    </form>
</body>
</html>
