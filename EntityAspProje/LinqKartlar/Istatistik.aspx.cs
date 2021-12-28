using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.LinqKartlar
{
    public partial class Istatistik : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLURUNLER.Count().ToString(); //TBLURUNLER' deki ürün sayısı
            Label2.Text = db.TBLMUSTERI.Count().ToString(); //TBLMUSTERI' deki müşteri sayısı
            Label3.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString(); //TBLSATIS' taki toplam satış
            Label4.Text = db.TBLKATEGORI.Count().ToString(); //TBLKATEGORI' deki müşteri sayısı
            Label5.Text = db.TBLURUNLER.Count(x => x.DURUM == true).ToString(); //TBLURUNLER' deki DURUM' u true olan ürünler
            Label6.Text = db.TBLURUNLER.Count(x => x.DURUM == false).ToString(); //TBLURUNLER' deki DURUM' u false olan ürünler
            Label7.Text = (from x in db.TBLURUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault(); //TBLURUNLER' deki stoğu en çok olanı getirir.
            
        }
    }
}