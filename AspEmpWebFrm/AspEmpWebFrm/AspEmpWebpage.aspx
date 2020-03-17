 <%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebFrmInsertPage.aspx.cs" Inherits="WebAppDatasetDemo.WebFrmInsertPage" %>
<asp:Content ID="in1234" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br \>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br \>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br \>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br \>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br \>

    <asp:Button ID="Button1" Text="Insert" runat="server" OnClick="Button1_Click"></asp:Button>

 </asp:Content>