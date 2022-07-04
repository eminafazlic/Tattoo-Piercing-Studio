using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Proizvod
    {
        public Proizvod()
        {
            StavkeNarudzbes = new HashSet<StavkeNarudzbe>();
        }

        public int ProizvodId { get; set; }
        public int? TipProizvodaId { get; set; }
        public decimal? Cijena { get; set; }
        public string Opis { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        public virtual TipProizvodum TipProizvoda { get; set; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbes { get; set; }
    }
}
