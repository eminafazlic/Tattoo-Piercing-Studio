using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Izvjestaj
    {
        public int IzvjestajId { get; set; }
        public int? UposlenikId { get; set; }
        public DateTime? Datum { get; set; }
        public string Detalji { get; set; }

        public virtual Uposlenik Uposlenik { get; set; }
    }
}
