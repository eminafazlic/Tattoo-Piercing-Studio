using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class Termin
    {
        public int TerminId { get; set; }
        public int? KlijentId { get; set; }
        public int? UposlenikId { get; set; }
        public DateTime? Datum { get; set; }
        public string Opis { get; set; }
        public decimal? Cijena { get; set; }
        public int? TipTerminaId { get; set; }
        public bool? IsOdobren { get; set; }
        public bool? IsPlacen { get; set; }
        public bool? IsOtkazan { get; set; }
        public string Komentar { get; set; }


        public virtual Klijent Klijent { get; set; }
        public virtual TipTermina TipTermina { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
    }
}
