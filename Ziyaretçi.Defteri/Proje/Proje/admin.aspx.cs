using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje
{
    public partial class admin : System.Web.UI.Page
    {
        SqlConnection con ; 

        public void mesajGoster()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from defterim order by onay desc", con);
            SqlDataReader rd = cmd.ExecuteReader();

            mess.InnerHtml = "<table border=1 width=100%>";
            mess.InnerHtml += "<tr style='color:red'><td>İSİM</td><td>MAİL</td><td>MESAJ</td><td>ONAY DURUMU</td><td>DÜZENLE</td><td>SİL</td></tr>";
            while (rd.Read())
            {
                String q = "";
                if(rd["onay"].ToString().Equals("0"))
                {
                    q="<a href='admin.aspx?islem=onayla&id="+rd["id"]+"'>Onayla</a>";
                }
                else
                {
                    q="onaylı";
                }
                mess.InnerHtml += "<tr><td>" + rd["isim"] + "</td><td>" + rd["mail"] + "</td><td>" + rd["mesaj"] + "</td><td>" + q + "</td><td><a href='admin.aspx?islem=duzenle&id=" + rd["id"] + "'>Düzenle</a></td><td><a href='admin.aspx?islem=sil&id=" + rd["id"] + "'>Sil</a></td></tr>";
            }
            mess.InnerHtml += "</table>";
            rd.Close();
            con.Close();
        }

        public void onayla(int id) 
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE defterim set onay=1 where id=@id",con);
            cmd.Parameters.AddWithValue("@id", id);
            int q= cmd.ExecuteNonQuery();
            /*if (q > 0)
            {
                Response.Write("<script>alert('Onaylandı');</script>");
            }*/
            Response.Redirect("admin.aspx");
            con.Close();
        }

        public void sil(int id)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from  defterim where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int q = cmd.ExecuteNonQuery();
            /*if (q > 0)
                Response.Write("<script>alert('Silindi');</script>");*/
            Response.Redirect("admin.aspx");
            con.Close();
        }

        public void duzenle(int id) 
        {
            mess.InnerHtml = "";
            con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();        
            SqlCommand cmd = new SqlCommand("SELECT * FROM defterim where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            mess.InnerHtml += "<form id='f1' method='get' action='up.aspx'><table>";
            while (rd.Read()) 
            {
                mess.InnerHtml += "<tr><td></td><td><input type='hidden' name='id'  value='" + rd["id"] + "'> </td><tr>";
                mess.InnerHtml += "<tr><td>İsim</td><td><input type='text' name='isim' id='isim' value='" + rd["isim"] + "'> </td><tr>";
                mess.InnerHtml += "<tr><td>Mesaj</td><td><textarea name='mesaj' id='mesaj'>" + rd["mesaj"] + "</textarea></td><tr>";
                mess.InnerHtml += "<tr><td>Onay durumu</td><td><select name='onay' id='ony'>" + rd["onay"] + "<option value='0'>Onaysız</option><option value='1'>Onaylı</option></select>";
                mess.InnerHtml += "<tr><td>&nbsp;</td><td><input type='submit' value='Güncelle'  > ";
            }
            mess.InnerHtml += "</table></form>";

            rd.Close();
            con.Close();   
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["giris"] != null)
            {
                String sayfa = Request.QueryString["islem"];

                if (String.IsNullOrEmpty(sayfa))
                {
                    mesajGoster();
                }
                else if (sayfa.Equals("onayla"))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    onayla(id);

                }

                else if (sayfa.Equals("sil"))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    sil(id);

                }


                else if (sayfa.Equals("duzenle"))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    duzenle(id);

                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
      }
   }
}
