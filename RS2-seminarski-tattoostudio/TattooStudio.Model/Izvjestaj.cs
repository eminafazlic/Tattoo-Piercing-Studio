using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class Izvjestaj
    {
        public int IzvjestajId { get; set; }
        public int? UposlenikId { get; set; }
        public DateTime? Datum { get; set; }
        public string Detalji { get; set; }

        public virtual Uposlenik Uposlenik { get; set; }

        public override string ToString()
        {
            return $"Izvještaj {Datum} za uposlenika {Uposlenik.Ime} {Uposlenik.Prezime} \n {Detalji}";
        }
    }
}
