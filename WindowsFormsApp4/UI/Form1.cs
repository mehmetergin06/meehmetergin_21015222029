using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.BL;
using WindowsFormsApp4.UI;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunE_Click(object sender, EventArgs e)
        {

        }

        private void btnMüşteriE_Click(object sender, EventArgs e)
        {
            Musteri Musteri = new Musteri()
            {
                Text = "Müşeri Ekle",
                musteri = new Musteria() { ID = Guid.NewGuid() },

            };
            var sonuc = Musteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                BLogic.MüşteriEkle(Musteri.musteri);


            }

        }

        private void btnMüşteriD_Click(object sender, EventArgs e)
        {

        }
    }
}
