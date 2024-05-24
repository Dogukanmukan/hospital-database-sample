using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedipolHastane
{
    public partial class bolum : Form
    {
        public bolum()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mdplhas;Integrated Security=True");

        public void BolumListele()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From tbl_blm", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgbolum.DataSource = dt;
            conn.Close();
        }
        private void bolum_Load(object sender, EventArgs e)
        {
            BolumListele();
        }

        private void btnekle3_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand sql = new SqlCommand("insert into tbl_blm(bolum) values (@bolum)", conn);
            sql.Parameters.AddWithValue("bolum", txtblm1.Text);

            sql.ExecuteNonQuery();
            MessageBox.Show("Bölüm Bilgisi Eklendi");
            conn.Close();
            BolumListele();
        }

        private void btnsil3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("Delete from tbl_blm Where Id=@id", conn);
            sql.Parameters.AddWithValue("@id", labelidB.Text);
            sql.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silinmiştir.");
            conn.Close();
            BolumListele();
        }

        private void btngnc3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("update tbl_blm set bolum=@bolum Where Id=@id", conn);
            sql.Parameters.AddWithValue("@bolum", txtblm1.Text);
            sql.Parameters.AddWithValue("@id", labelidB.Text);
            sql.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellenmiştir.");
            conn.Close();
            BolumListele();
        }

        private void dgbolum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelidB.Text = dgbolum.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtblm1.Text = dgbolum.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
