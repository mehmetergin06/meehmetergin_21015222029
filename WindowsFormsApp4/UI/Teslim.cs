using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.UI
{
    public partial class Teslim : Form
    {
        public Teslim()
        {
            InitializeComponent();
        }
        
        private void Teslim_Load(object sender, EventArgs e)
        {
            textID.Text = teslim.ID.ToString();
            textMusteri.Text = Musteri.ToString();
            textUrun.Text = Urun.ToString();
        }
        public Musteria Musteri { get;  set; }
        public Uruna Urun { get; set; }
        public Teslima teslim { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(textFiyat.Value==0)
            {
                errorProvider1.SetError(textFiyat, "Lütfen geçerli bir sayı giriniz");
                textFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textFiyat, "");
            }
            teslim.Tutar = (double)textFiyat.Value;
            teslim.Tarih = textTarih.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
