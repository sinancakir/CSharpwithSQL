using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Proje
{
    public partial class yenimesaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into defterim (mesaj,mail,tarih,isim,onay) values (@mesaj,@mail,@tarih,@isim,@onay)", con);
            cmd.Parameters.AddWithValue("@mesaj", txtmesaj.Text);
            cmd.Parameters.AddWithValue("@mail", txtmail.Text);
            cmd.Parameters.AddWithValue("@isim", txtisim.Text);
            cmd.Parameters.AddWithValue("@tarih", dt.ToShortDateString());
            cmd.Parameters.AddWithValue("@onay", 0);

            int q = cmd.ExecuteNonQuery();
            if (q > 0)
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}