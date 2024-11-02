using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOdev1
{
    internal class Ev
    {
        int _alan, _odaSayisi;
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public int Alan 
        { 
            get { return _alan; } 
            set
            {
                try
                {

                    if (value < 0)
                        _alan = 1;
                    else if (value > 100)
                        _alan = 100;
                    else
                        _alan = value;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hatalı Alan Girişi");
                }
            }
        }
        public int OdaSayisi 
        {
            get => _odaSayisi;

            set
            {
                try
                {
                    if (value < 0) 
                        _odaSayisi = 1;
                    else if (_odaSayisi > 5)
                        _odaSayisi = 5;
                    else
                        _odaSayisi = value;
                }
                catch (Exception ex) { throw new Exception("Hatalı Oda Girişi"); }
            }
        }
        public string Isinma { get; set; }

    }
}
