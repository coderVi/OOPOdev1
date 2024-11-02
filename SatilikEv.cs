using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOdev1
{
    internal class SatilikEv : Ev
    {
        int _fiyat;
        public int Fiyat
        { 
            
            get { return _fiyat; } 
            set
            {
                try { _fiyat = Math.Abs(value); }
                catch (Exception ex) { throw new Exception("Satılık ev fiyatı belirlenen aralık dışında"); }
            }
        }
        public string Telefon { get; set; }
    }
}
