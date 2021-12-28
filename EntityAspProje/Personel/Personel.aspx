<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="EntityAspProje.Personel.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#Modal1">
        Yeni Personel Tanımla
    </button>
    <div class="modal" id="Modal1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 class="modal-title">Personel Ekleme Paneli</h2>
                </div>
                <form runat="server">
                    <div class="modal-body">
                        <label>
                          Personel Ad Soyad
                        </label>
                        <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="BtnKaydet_Click"/>
                        <asp:Button ID="BtnVazgec" runat="server" Text="Vazgeç" CssClass="btn btn-danger" data-dismiss="modal"/>
                    </div>
                </form>
            </div>
        </div>
    </div>

    <table class="table table-bordered" style="margin-top:20px">
        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("PERSONELID") %></td>
                    <td><%#Eval("PERSONELADSOYAD") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
