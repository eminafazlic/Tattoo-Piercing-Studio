using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Obavijest
    {
        public int ObavijestId { get; set; }
        public int? UposlenikId { get; set; }
        public DateTime? Datum { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }

        public virtual Uposlenik Uposlenik { get; set; }
    }
}
