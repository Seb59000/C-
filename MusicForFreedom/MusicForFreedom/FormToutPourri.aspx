<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormToutPourri.aspx.cs" Inherits="MusicForFreedom.FormToutPourri"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Chiffre"></asp:Label>
    <asp:TextBox ID="tbPseudo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbPseudo" ErrorMessage="Required"></asp:RequiredFieldValidator>

        <asp:Label ID="Label2" runat="server" Text="text"></asp:Label>
    <asp:TextBox ID="tbMail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbMail" ErrorMessage="Required"></asp:RequiredFieldValidator>

        <asp:Label ID="Label3" runat="server" Text="text"></asp:Label>
    <asp:TextBox ID="tbMotdePasse" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbMotdePasse" ErrorMessage="Required"></asp:RequiredFieldValidator>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  />
</asp:Content>
