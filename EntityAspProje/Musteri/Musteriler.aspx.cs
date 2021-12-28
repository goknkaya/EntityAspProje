using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var values = db.TBLMUSTERI.ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLMUSTERI musteri = new TBLMUSTERI();
            musteri.MUSTERIAD = TxtAd.Text;
            musteri.MUSTERISOYAD = TxtSoyad.Text;
            db.TBLMUSTERI.Add(musteri);
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");
        }
    }
}