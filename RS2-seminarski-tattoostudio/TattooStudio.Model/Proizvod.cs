using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class Proizvod
    {
        public int ProizvodId { get; set; }
        public int? TipProizvodaId { get; set; }
        public double? Cijena { get; set; }
        public string Opis { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        //public virtual TipProizvodum TipProizvodum { get; set; }
        //public virtual ICollection<StavkeNarudzbe> StavkeNarudzbes { get; set; }

    }
}
