using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            Izvjestajs = new HashSet<Izvjestaj>();
            Obavijests = new HashSet<Obavijest>();
            Termins = new HashSet<Termin>();
        }

        public int UposlenikId { get; set; }
        public int? ZanimanjeId { get; set; }
        public int? SpolId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }

        public virtual Spol Spol { get; set; }
        public virtual Zanimanje Zanimanje { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        public virtual ICollection<Izvjestaj> Izvjestajs { get; set; }
        public virtual ICollection<Obavijest> Obavijests { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}
