using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            StavkeNarudzbes = new HashSet<StavkeNarudzbe>();
        }

        public int NarudzbaId { get; set; }
        public int? KlijentId { get; set; }
        public DateTime? Datum { get; set; }
        public decimal? UkupniIznos { get; set; }
        public bool? IsIsporucena { get; set; }
        public bool? IsPlacena { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbes { get; set; }
    }
}
