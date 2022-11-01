<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adauga-Punct.aspx.cs" Inherits="WebS5.Adauga_Punct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Denumire" AssociatedControlID="txtDenumire" CssClass="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtDenumire" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="X" AssociatedControlID="txtX" CssClass="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtX" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Y" AssociatedControlID="txtY" CssClass="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtY" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <div class="checkbox">
                    <asp:CheckBox ID="chkEsteVizibil" runat="server" />
                    <asp:Label ID="Label1" runat="server" Text="Este vizibil?" AssociatedControlID="chkEsteVizibil"></asp:Label>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" CssClass="btn btn-success" />
            </div>
        </div>
    </div>

</asp:Content>
