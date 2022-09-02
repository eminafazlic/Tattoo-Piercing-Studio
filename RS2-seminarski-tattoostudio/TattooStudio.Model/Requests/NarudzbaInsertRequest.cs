using System;
using System.Collections.Generic;

namespace TattooStudio.Model.Requests
{
    public class NarudzbaInsertRequest
    {
        public int? KlijentId { get; set; }
        public DateTime? Datum { get; set; }
        public double? UkupniIznos { get; set; }
        public bool? IsIsporucena { get; set; }
        public bool? IsPlacena { get; set; }
        //public List<int> Proizvodi { get; set; } = new List<int>();
        //public List<int> Kolicine { get; set; } = new List<int>();
        //public virtual ICollection<StavkeNarudzbe> StavkeNarudzbes { get; set; }
    }
}
