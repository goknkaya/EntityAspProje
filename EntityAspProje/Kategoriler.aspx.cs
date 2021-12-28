using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e) //Kategori Listeleme işlemi
        {
            var values = db.TBLKATEGORI.ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}