using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAddCategory_Click(object sender, EventArgs e) //Kategori ekleme işlemi
        {
            BONUSASPDBEntities db = new BONUSASPDBEntities();
            TBLKATEGORI t = new TBLKATEGORI();
            t.KATEGORIAD = TxtCategoryName.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}