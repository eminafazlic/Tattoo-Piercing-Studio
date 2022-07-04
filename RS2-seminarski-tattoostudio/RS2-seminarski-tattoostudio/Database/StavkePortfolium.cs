using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class StavkePortfolium
    {
        public int StavkaPortfoliaId { get; set; }
        public int? PortfolioId { get; set; }
        public DateTime? Datum { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}
