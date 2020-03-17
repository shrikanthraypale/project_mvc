<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFrmShowdata.aspx.cs" Inherits="WebAppDatasetDemo.WebFrmShowdata" %>

<asp:Content ID="my123" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
</asp:Content>
