using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var urun = (from x in db.TBLURUNLER where (x.DURUM==true)
                            select new
                            {
                                x.URUNID,
                                x.URUNAD,
                                x.URUNMARKA,
                                x.TBLKATEGORI.KATEGORIAD, //Farklı tablo olan TBLKATEGORI' den KATEGORIAD' ı bu şekilde seçiyoruz.
                                x.URUNFIYAT,
                                x.URUNSTOK
                            }).ToList();
            //var urun = db.TBLURUNLER.ToList();
            //var urun = db.TBLURUNLER.Where(x=>x.DURUM==true).ToList(); //Sadece durumu True olanları getirecek.
            Repeater1.DataSource = urun;
            Repeater1.DataBind();
        }
    }
}