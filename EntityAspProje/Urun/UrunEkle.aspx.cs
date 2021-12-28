using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e) //Kategorilerin listelenmesi
        {
            if (Page.IsPostBack==false)
            {
                var kategori = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList(); //TBLKATEGORI içerisinde bir x nesnesi olsun ve bu x nesnesi...
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kategori;
                DropDownList1.DataBind();
            }
            
        }

        protected void BtnAddProduct_Click(object sender, EventArgs e) //Yeni ürün ekleme
        {
            TBLURUNLER urun = new TBLURUNLER(); //TBLURUNLER tablosundan t sınıfı üretiyoruz.
            urun.URUNAD = TxtUrunAd.Text;
            urun.URUNMARKA = TxtUrunMarka.Text;
            urun.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue);
            urun.URUNFIYAT = decimal.Parse(TxtUrunFiyat.Text);
            urun.URUNSTOK = short.Parse(TxtUrunStok.Text);
            urun.DURUM = true;
            db.TBLURUNLER.Add(urun); //Ekleme işlemi
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}