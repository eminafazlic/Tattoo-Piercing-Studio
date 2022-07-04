using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class TipProizvodum
    {
        public TipProizvodum()
        {
            Proizvods = new HashSet<Proizvod>();
        }

        public int TipProizvodaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvod> Proizvods { get; set; }
    }
}
