<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminNavbar.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="ProjectPSD.Views.Admin.ManageMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="makeupGV" style="margin-bottom:10px" AutoGenerateColumns="false" runat="server" OnRowEditing="rowEditing" OnRowDeleting="rowDeleting">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName"></asp:BoundField>
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice"></asp:BoundField>
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight"></asp:BoundField>
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="MakeupType" SortExpression="MakeupType.MakeupTypeName"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="MakeupBrand" SortExpression="MakeupBrand.MakeupBrandName"></asp:BoundField>
            <asp:BoundField DataField="MakeupBrand.MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrand.MakeupBrandRating"></asp:BoundField>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Command"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <div style="display:flex">
        <asp:GridView ID="makeupTypeGV" Style="margin-right: 10px" AutoGenerateColumns="false" runat="server" OnRowEditing="muTypeEdit">
            <Columns>
                <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID"></asp:BoundField>
                <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName"></asp:BoundField>
            <asp:CommandField ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Edit"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <asp:GridView ID="makeupBrandGV" AutoGenerateColumns="false" runat="server" OnRowEditing="muBrandEdit">
            <Columns>
                <asp:BoundField DataField="MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrandID"></asp:BoundField>
                <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName"></asp:BoundField>
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrandRating"></asp:BoundField>
                <asp:CommandField ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Edit"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Insert : "></asp:Label>
        <asp:Button ID="newMU" OnClick="newMU_Click" runat="server" Text="Makeup" />
        <asp:Button ID="newMUT" OnClick="newMUT_Click" runat="server" Text="Type" />
        <asp:Button ID="newMUB" OnClick="newMUB_Click" runat="server" Text="Brand" />
    </div>
</asp:Content>
