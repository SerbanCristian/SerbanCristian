<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista-Puncte.aspx.cs" Inherits="WebS5.Lista_Puncte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GVPuncte" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="denumire" HeaderText="Punct" />
            <asp:BoundField DataField="dataCreare" DataFormatString="{0:dd MMMM yy, HH:mm}" HeaderText="Data" />
        </Columns>
    </asp:GridView>
</asp:Content>
