using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class StavkePortfolium
    {
        public int StavkaPortfoliaId { get; set; }
        public int? PortfolioId { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
    }
}
