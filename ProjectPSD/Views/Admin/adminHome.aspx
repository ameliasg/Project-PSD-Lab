<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminNavbar.Master" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="ProjectPSD.Views.Admin.adminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="customerGV" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName"></asp:BoundField>
            <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail"></asp:BoundField>
            <asp:BoundField DataField="UserDOB" HeaderText="UserDOB" SortExpression="UserDOB"></asp:BoundField>
            <asp:BoundField DataField="UserGender" HeaderText="UserGender" SortExpression="UserGender"></asp:BoundField>
            <asp:BoundField DataField="UserRole" HeaderText="UserRole" SortExpression="UserRole"></asp:BoundField>
            <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
