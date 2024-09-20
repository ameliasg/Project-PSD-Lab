<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminNavbar.Master" AutoEventWireup="true" CodeBehind="TransactionHandler.aspx.cs" Inherits="ProjectPSD.Views.Admin.TransactionHandler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="unhandledGV" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
                <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status"></asp:BoundField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="details" OnClick="details_Click" runat="server" Text="Details" />
                        <asp:Button ID="handle" OnClick="handle_Click" runat="server" Text="Handle" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:GridView ID="handledGV" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID"></asp:BoundField>
                <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"></asp:BoundField>
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate"></asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status"></asp:BoundField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="details" OnClick="details_Click" runat="server" Text="Details" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
