using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Narudzbas = new HashSet<Narudzba>();
            Termins = new HashSet<Termin>();
        }

        public int KlijentId { get; set; }
        public int? SpolId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual Spol Spol { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}
