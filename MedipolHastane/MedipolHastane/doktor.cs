using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedipolHastane
{
    public partial class doktor : Form
    {
        public doktor()
        {
            InitializeComponent();
        }
        mdplhasEntities mpe = new mdplhasEntities();
         
        public void DoktorListele()
        {
            dgdoktor.DataSource = mpe.tbl_dok.ToList();
        }
        public void sil()
        {
           txtdok1.Text = txtdok2.Text = txtdok3.Text = labelidD.Text = " ";
        }


            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doktor_Load(object sender, EventArgs e)
        {
            DoktorListele();   
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_dok doktor = new tbl_dok(); 
            doktor.adsoyad = txtdok1.Text; 
            doktor.tc = txtdok2.Text;
            doktor.bolum = txtdok3.Text;

            mpe.tbl_dok.Add(doktor); 
            mpe.SaveChanges(); 
            MessageBox.Show("Bilgiler Başarıyla Kaydedildi.");
            DoktorListele();
            sil();


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int doktor = Convert.ToInt32(labelidD.Text);
            var delete = mpe.tbl_dok.First(x => x.Id == doktor);

            mpe.tbl_dok.Remove(delete);
            mpe.SaveChanges();
            MessageBox.Show("Bilgiler Başarıyla Silinmiştir.");
            DoktorListele();
            sil();
        }

        private void dgdoktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgdoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelidD.Text = dgdoktor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdok1.Text = dgdoktor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdok2.Text = dgdoktor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdok3.Text = dgdoktor.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void btngnc_Click(object sender, EventArgs e)
        {
            int doktor = Convert.ToInt32(labelidD.Text);
            var update = mpe.tbl_dok.First(x => x.Id == doktor);
            update.tc = txtdok2.Text;
            update.adsoyad = txtdok1.Text;
            update.bolum = txtdok3.Text;

            mpe.SaveChanges();
            MessageBox.Show("Bilgiler Başarıyla Güncellenmiştir.");
            DoktorListele();
            sil();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
