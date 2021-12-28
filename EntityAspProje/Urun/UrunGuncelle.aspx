<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün Adı"></asp:Label>
            <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün adını girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Marka Adı"></asp:Label>
            <asp:TextBox ID="TxtUrunMarka" runat="server" placeholder="Markayı girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Kategori"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Fiyatı"></asp:Label>
            <asp:TextBox ID="TxtUrunFiyat" runat="server" placeholder="Fiyatı girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label5" runat="server" Text="Stok"></asp:Label>
            <asp:TextBox ID="TxtUrunStok" runat="server" placeholder="Stok sayısını girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="BtnUpdateProduct" runat="server" Text="Ürün Güncelle" CssClass="btn btn-primary" OnClick="BtnUpdateProduct_Click"/>
        </div>
    </form>

</asp:Content>
