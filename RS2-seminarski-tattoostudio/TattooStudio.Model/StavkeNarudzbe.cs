using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class StavkeNarudzbe
    {
        public int StavkeNarudzbeId { get; set; }
        public int? NarudzbaId { get; set; }
        public Narudzba Narudzba { get; set; }
        public int? ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public int? Kolicina { get; set; }
    }
}
