using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace deneme
{
    public partial class Default : System.Web.UI.Page
    {
        public void dbGoster()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ogrenci;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ogrenci", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dbGoster();
            eklepanel.Visible = false;
            silpanel.Visible = false;
            guncellepanel.Visible = false;
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ogrenci;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select ogrenci_no from ogrenci", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DropDownList1.Items.Add("Öğrenci Numarası Seç");
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr["ogrenci_no"].ToString());
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            eklepanel.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            silpanel.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            guncellepanel.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ogrenci;Integrated Security=True");
            con.Open();
            string sql = "insert into ogrenci(ogrenci_isim,ogrenci_bolum,ogrenci_sinif,ogrenci_yas) values(@isim,@bolum,@sinif,@yas)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@isim", txtisim.Text);
            cmd.Parameters.AddWithValue("@bolum", txtbolum.Text);
            cmd.Parameters.AddWithValue("@sinif", txtsinif.Text);
            cmd.Parameters.AddWithValue("@yas", txtyas.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dbGoster();
            eklepanel.Visible = true;
            txtisim.Text = "";
            txtbolum.Text = "";
            txtsinif.Text = "";
            txtyas.Text = "";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ogrenci;Integrated Security=True");
            con.Open();
            string sql2 = "delete  from ogrenci where ogrenci_no='" + txtnosil.Text + "'";
            SqlCommand cmd = new SqlCommand(sql2, con);
            cmd.ExecuteScalar();
            con.Close();
            dbGoster();
            silpanel.Visible = true;
            txtnosil.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ogrenci;Integrated Security=True");
            con.Open();
            string sql2 = "update ogrenci set ogrenci_isim='" + txtisim0.Text + "',ogrenci_bolum='" + txtbolum0.Text + "', ogrenci_sinif='" + txtsinif0.Text + "',ogrenci_yas='" + txtyas0.Text + "' where ogrenci_no='" + DropDownList1.SelectedItem.Value + "'";
            SqlCommand cmd = new SqlCommand(sql2, con);
            cmd.ExecuteScalar();
            con.Close();
            dbGoster();
            guncellepanel.Visible = true;

            txtisim0.Text = "";
            txtbolum0.Text = "";
            txtsinif0.Text = "";
            txtyas0.Text = "";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            eklepanel.Visible = false;
            silpanel.Visible = false;
            guncellepanel.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex != 0)
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ogrenci;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select ogrenci_isim,ogrenci_bolum,ogrenci_sinif,ogrenci_yas from ogrenci where ogrenci_no=" + Convert.ToInt32(DropDownList1.SelectedValue) + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtisim0.Text = dr["ogrenci_isim"].ToString();
                    txtsinif0.Text = dr["ogrenci_sinif"].ToString();
                    txtbolum0.Text = dr["ogrenci_bolum"].ToString();
                    txtyas0.Text = dr["ogrenci_yas"].ToString();
                }

                guncellepanel.Visible = true;
            }

        }
    }
}