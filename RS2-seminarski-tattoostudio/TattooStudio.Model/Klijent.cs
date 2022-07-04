using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public partial class Klijent
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int SpolId { get; set; }
        public virtual Spol Spol { get; set; }

        public override string ToString()
        {
            return $"{KorisnickoIme} {Ime} {Prezime}";
        }
    }
}
