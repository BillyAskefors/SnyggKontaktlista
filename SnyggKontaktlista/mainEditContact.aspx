<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mainEditContact.aspx.cs" Inherits="SnyggKontaktlista.WebForm1" %>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">

    <asp:Literal id ="changeContact" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:TextBox ID="tb_firstname" runat="server"></asp:TextBox>
    <asp:TextBox ID="tb_lastname" runat="server"></asp:TextBox>
    <asp:TextBox ID="tb_ssn" runat="server"></asp:TextBox>
    <asp:Button ID="btn_edit" runat="server" OnClick="btn_edit_Click" Text="Editera" />
    <br />
    Förnamn&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Efternamn&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SSN<br />
    <br />
    <br />
</asp:Content>
