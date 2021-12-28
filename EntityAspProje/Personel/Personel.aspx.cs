using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Personel
{
    public partial class Personel : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var values = db.TBLPERSONEL.ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL personel = new TBLPERSONEL();
            personel.PERSONELADSOYAD = TxtAdSoyad.Text;
            db.TBLPERSONEL.Add(personel);
            db.SaveChanges();
            Response.Redirect("Personel.aspx");
        }
    }
}