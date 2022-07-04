using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Zanimanje
    {
        public Zanimanje()
        {
            Uposleniks = new HashSet<Uposlenik>();
        }

        public int ZanimanjeId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}
