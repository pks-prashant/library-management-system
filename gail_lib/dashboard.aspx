<%@ Page Title="DASHBOARD" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="gail_lib.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Dashboard</h1>
    <asp:Label ID="h" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="LogOut" OnClick="Button1_Click" />
    <a href="adminbookinventory.aspx">book inventory</a>
</asp:Content>
