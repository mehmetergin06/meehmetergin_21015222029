using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Musteria
    { 
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
    public class Uruna
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public string Detay { get; set; }
        public override string ToString()
        {
            return $"{Ad} {Detay}";
        }
    }
    public class Teslima
    {
        public Guid ID { get; set; }
        public Musteria Musteri { get; set; }
        public Uruna Urun { get; set; }
        public DateTime Tarih { get; set; }

        public double Tutar { get; set; }


    }
    public class Odemea
    {
        public Guid ID { get; set; }
        public double Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public string Tur { get; set; }
        public string Aciklama { get; set; }
    }
   
}
