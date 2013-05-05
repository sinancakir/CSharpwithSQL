using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje
{
    public partial class yonetim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if( Session["giris"] != null)
           {
               Response.Redirect("Admin.aspx");
           }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from yonetim where (isim=@isim AND sifre=@sifre )", con);
            cmd.Parameters.AddWithValue("@isim",  kadi.Text);
            cmd.Parameters.AddWithValue("@sifre", sifre.Text);

            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                Session["giris"] = true;
                Response.Redirect("Admin.aspx");
            }
            con.Close();
        }  
    }
}