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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public Musteria musteri { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textAD)) return;
            if (!ErrorControl(textSoy)) return;
            if (!ErrorControl(textTel)) return;
            if (!ErrorControl(textMail)) return;
            if (!ErrorControl(textAdres)) return;

            musteri.Ad = textAD.Text;
            musteri.Soyad = textSoy.Text;
            musteri.Telefon = textTel.Text;
            musteri.Mail = textMail.Text;
            musteri.Adres = textAdres.Text;


            DialogResult = DialogResult.OK;
        }
       
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
