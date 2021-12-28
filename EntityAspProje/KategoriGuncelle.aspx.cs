using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e) //Kategoriler sayfasında ilgili kategorinin karşısındaki Güncelle butonuna basıldığında kategori adını getirir.
        {
            if (Page.IsPostBack==false) //Bunu eklemediğimiz zaman sayfa güncelleme yapsa bile eski değerleri getirir.
            {
                int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                TxtCategoryID.Text = id.ToString();
                var categoryName = db.TBLKATEGORI.Find(id); //TBLKATEGORI tablosu içerisinde id değerini bul ve category' e aktar.
                TxtCategoryName.Text = categoryName.KATEGORIAD;
            }
        }

        protected void BtnUpdateCategory_Click(object sender, EventArgs e) //Kategori güncelleme
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var categoryName = db.TBLKATEGORI.Find(id);
            categoryName.KATEGORIAD = TxtCategoryName.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}