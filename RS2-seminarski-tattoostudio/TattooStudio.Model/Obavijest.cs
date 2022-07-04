using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class Obavijest
    {
        public int ObavijestId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? Datum { get; set; }
        public int UposlenikId { get; set; }
        public Uposlenik Uposlenik { get; set; }
    }
}
