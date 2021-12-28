using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) //Bunu eklemediğimiz zaman sayfa güncelleme yapsa bile eski değerleri getirir.
            {
                KategoriGetir();

                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var urun = db.TBLURUNLER.Find(id); //TBLURUNLER tablosu içerisinde id değerini bul ve product' a aktar.
                TxtUrunAd.Text = urun.URUNAD;
                TxtUrunStok.Text = urun.URUNSTOK.ToString();
                TxtUrunMarka.Text = urun.URUNMARKA;
                TxtUrunFiyat.Text = urun.URUNFIYAT.ToString();
                DropDownList1.SelectedValue = urun.URUNKATEGORI.ToString();
            }
        }

        void KategoriGetir()
        {
            var kategori = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList(); //TBLKATEGORI içerisinde bir x nesnesi olsun ve bu x nesnesi...
            DropDownList1.DataTextField = "KATEGORIAD";
            DropDownList1.DataValueField = "KATEGORIID";
            DropDownList1.DataSource = kategori;
            DropDownList1.DataBind();
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun = db.TBLURUNLER.Find(id);
            urun.URUNAD = TxtUrunAd.Text;
            urun.URUNSTOK = short.Parse(TxtUrunStok.Text);
            urun.URUNMARKA = TxtUrunMarka.Text;
            urun.URUNFIYAT = Decimal.Parse(TxtUrunFiyat.Text);
            urun.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}