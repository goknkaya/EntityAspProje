using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.TBLURUNLER select new { x.URUNID, x.URUNAD }).ToList(); //TBLURUNLER içerisinde bir x nesnesi olsun ve bu x nesnesi...
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var musteri = (from x in db.TBLMUSTERI
                               select new
                               {
                                   x.MUSTERIID,
                                   MUSTERI = x.MUSTERIAD + " " + x.MUSTERISOYAD
                               }).ToList(); //TBLMUSTERI içerisinde bir x nesnesi olsun ve bu x nesnesi...
                DropDownList2.DataTextField = "MUSTERI";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = musteri;
                DropDownList2.DataBind();

                var personel = (from x in db.TBLPERSONEL select new { x.PERSONELID, x.PERSONELADSOYAD }).ToList(); //TBLPERSONEL içerisinde bir x nesnesi olsun ve bu x nesnesi...
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = personel;
                DropDownList3.DataBind();
            }
        }

        protected void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TBLSATIS satis = new TBLSATIS();
            satis.URUN = int.Parse(DropDownList1.SelectedValue);
            satis.MUSTERI = int.Parse(DropDownList2.SelectedValue);
            satis.PERSONEL = byte.Parse(DropDownList3.SelectedValue);
            satis.FIYAT = decimal.Parse(TxtFiyat.Text);
            db.TBLSATIS.Add(satis);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}