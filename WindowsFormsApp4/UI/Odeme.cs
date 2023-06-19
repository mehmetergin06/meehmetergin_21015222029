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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        public Odemea odeme { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {


            if (textTutar.Value == 0)
            {
                errorProvider1.SetError(textTutar, "Lütfen geçerli bir sayı giriniz");
                textTutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textTutar, "");
            }
            if (textTur.SelectedItem==null)
            {
                errorProvider1.SetError(textTur, "Ödeme türü seçiniz");
                textTur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textTur, "");
                
            }
            if (textAçıklama.Text == "")
            {
                errorProvider1.SetError(textAçıklama, "Lütfen açıklama yazınız");
                textAçıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textAçıklama, "");
                
            }
            odeme.Tutar = (double)textTutar.Value;
            odeme.Tarih = textTarih.Value;
            odeme.Tur = textTur.Text;
            odeme.Aciklama = textAçıklama.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
