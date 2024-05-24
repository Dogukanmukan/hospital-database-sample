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
    public partial class hasta : Form
    {
        public hasta()
        {
            InitializeComponent();
        }
        mdplhasEntities mpe = new mdplhasEntities();
        public void HastaListele()
        {
            dghasta.DataSource = mpe.tbl_hasta.ToList();
        }

        public void sil()
        {
            txthst1.Text = txthst2.Text = txthst3.Text = labelidH.Text = " ";
        }

        private void hasta_Load(object sender, EventArgs e)
        {
            HastaListele();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnekle1_Click(object sender, EventArgs e)
        {
            tbl_hasta hasta = new tbl_hasta();
            hasta.adsoyad = txthst1.Text;
            hasta.tc = txthst2.Text;
            hasta.bolum = txthst3.Text;

            mpe.tbl_hasta.Add(hasta);
            mpe.SaveChanges();
            MessageBox.Show("Bilgiler Başarıyla Kaydedildi.");
            HastaListele();
            sil();
        }

        private void btnsil2_Click(object sender, EventArgs e)
        {
            int hasta = Convert.ToInt32(labelidH.Text);
            var delete = mpe.tbl_hasta.First(x => x.Id == hasta);

            mpe.tbl_hasta.Remove(delete);
            mpe.SaveChanges();
            MessageBox.Show("Bilgiler Başarıyla Silinmiştir.");
            HastaListele();
            sil();
        }

        private void dghasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelidH.Text = dghasta.Rows[e.RowIndex].Cells[0].Value.ToString();
            txthst1.Text = dghasta.Rows[e.RowIndex].Cells[1].Value.ToString();
            txthst2.Text = dghasta.Rows[e.RowIndex].Cells[2].Value.ToString();
            txthst3.Text = dghasta.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btngnc2_Click(object sender, EventArgs e)
        {
            int hasta = Convert.ToInt32(labelidH.Text);
            var update = mpe.tbl_hasta.First(x => x.Id == hasta);
            update.tc = txthst2.Text;
            update.adsoyad = txthst1.Text;
            update.bolum = txthst3.Text;

            mpe.SaveChanges();
            MessageBox.Show("Bilgiler Başarıyla Güncellenmiştir.");
            HastaListele();
            sil();
        }
    }
}
