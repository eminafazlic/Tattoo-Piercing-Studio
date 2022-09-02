using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class Narudzba
    {
        public int NarudzbaId { get; set; }
        public int? KlijentId { get; set; }
        public DateTime? Datum { get; set; }
        public int? UkupniIznos { get; set; }
        public bool? IsIsporucena { get; set; }
        public bool? IsPlacena { get; set; }


        public virtual Klijent Klijent { get; set; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbes { get; set; }
    }
}
