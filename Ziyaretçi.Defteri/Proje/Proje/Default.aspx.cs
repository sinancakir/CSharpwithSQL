using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Proje
{
    public partial class Default : System.Web.UI.Page
    {
        public void mesajGoster()
        {
            SqlConnection con= new SqlConnection("Data Source=.;Initial Catalog=defter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from defterim where onay=1 order by id desc", con);
            SqlDataReader rd = cmd.ExecuteReader();

            mess.InnerHtml = "<table border=0 width=100%  cellpadding=10 cellspacing=10 style='border-collapse:collapse'>";
            while (rd.Read()) 
            {
                mess.InnerHtml += "<tr style='background-color:black;color:white;border-radius:5px;border:1px '><td>" + rd["isim"] + " tarafından " + rd["tarih"] + " tarihinde yazıldı</td></tr>";
                mess.InnerHtml += "<tr style='background-color:yellow;color:black'><td>" + rd["mesaj"] + "</td></tr><tr><td></td></tr> "; 
            }
            mess.InnerHtml += "</table>";
            rd.Close();
            con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mesajGoster();                
        }
    }
}