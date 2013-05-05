using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje
{
    public partial class up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String isim = Request.QueryString["isim"];
            String mesaj = Request.QueryString["mesaj"];
            int onay = Convert.ToInt32(Request.QueryString["onay"]);
            int id = Convert.ToInt32(Request.QueryString["id"]);

            SqlConnection con ; 
            con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update defterim set isim=@isim,mesaj=@mesaj,onay=@onay where id=@id", con);

            cmd.Parameters.AddWithValue("@isim", isim);
            cmd.Parameters.AddWithValue("@mesaj",mesaj);
            cmd.Parameters.AddWithValue("@onay", onay);
            cmd.Parameters.AddWithValue("@id", id);
            
            cmd.ExecuteNonQuery();
            Response.Redirect("admin.aspx");

            /*if (!String.IsNullOrEmpty(mesaj) && !String.IsNullOrEmpty(isim) && !String.IsNullOrEmpty(onay.ToString()))
                Response.Redirect("admin.aspx");
            //Response.Write("<script>alert('Güncellendi');</script>");
            else
                Response.Write("<script>alert('Güncelleme Hatalı');</script>");*/  

            con.Close();           
        }
    }
}