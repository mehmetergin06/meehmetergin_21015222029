using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.DL;

namespace WindowsFormsApp4.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteria m)
        {
            try
            {

            
            int res = DataLayer.MüşteriEkle(m);
           
                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu:"+ex.Message);
                return false;
            }
        }
    }
}
