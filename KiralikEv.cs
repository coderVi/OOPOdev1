using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOdev1
{
    internal class KiralikEv : Ev
    {
        int _fiyat, _depozito;
        DateTime _tarih;
        public int Fiyat { get => _fiyat; set => _fiyat = Math.Abs(value); }
        public int Depozito { get => _depozito; set => _depozito = Math.Abs(value); }
        public DateTime Tarih { 
            get => _tarih; 
            set
            {
                if (value < DateTime.Now)
                    _tarih = DateTime.Now;
            }
        }
        public string Telefon { get; set; }
    }
}
