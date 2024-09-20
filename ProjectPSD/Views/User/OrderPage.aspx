<%@ Page Title="" Language="C#" MasterPageFile="~/Views/User/UserNavbar.Master" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="ProjectPSD.Views.User.OrderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="MakeupGV" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName"></asp:BoundField>
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice"></asp:BoundField>
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight"></asp:BoundField>
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="MakeupType" SortExpression="MakeupType.MakeupTypeName"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="MakeupBrand" SortExpression="MakeupBrand.MakeupBrandName"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrand.MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrand.MakeupBrandRating"></asp:BoundField>
            <asp:TemplateField HeaderText="Order">
                <ItemTemplate>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Qty : "></asp:Label>
                        <asp:TextBox ID="itemQty" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        <asp:Button ID="orderBtn" OnClick="orderBtn_Click" runat="server" Text="Order" />
                    </div>
                    <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <h1>Cart :</h1>
    <asp:GridView ID="cartGV" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="Makeup.MakeupName" HeaderText="MakeupName" SortExpression="Makeup.MakeupName"></asp:BoundField>
            <asp:BoundField DataField="Makeup.MakeupPrice" HeaderText="MakeupPrice" SortExpression="Makeup.MakeupPrice"></asp:BoundField>
            <asp:BoundField DataField="Makeup.MakeupWeight" HeaderText="MakeupWeight" SortExpression="Makeup.MakeupWeight"></asp:BoundField>
            <asp:BoundField DataField="Makeup.MakeupType.MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="Makeup.MakeupType.MakeupTypeName"></asp:BoundField>
            <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="Makeup.MakeupBrand.MakeupBrandName"></asp:BoundField>
            <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="Makeup.MakeupBrand.MakeupBrandRating"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="clearCart" OnClick="clearCart_Click" runat="server" Text="Clear Cart"/>
    <asp:Button ID="checkOut" OnClick="checkOut_Click" runat="server" Text="Checkout"/>
</asp:Content>
