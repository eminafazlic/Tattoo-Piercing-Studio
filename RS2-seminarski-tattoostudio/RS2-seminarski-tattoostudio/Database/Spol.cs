using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Spol
    {
        public Spol()
        {
            Klijents = new HashSet<Klijent>();
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int SpolId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Klijent> Klijents { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
