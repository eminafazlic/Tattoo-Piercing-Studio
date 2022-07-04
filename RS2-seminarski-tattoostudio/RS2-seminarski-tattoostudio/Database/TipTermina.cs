using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class TipTermina
    {
        public TipTermina()
        {
            Termins = new HashSet<Termin>();
        }

        public int TipTerminaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Termin> Termins { get; set; }
    }
}
