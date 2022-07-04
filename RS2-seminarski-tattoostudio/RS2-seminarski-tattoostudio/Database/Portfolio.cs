using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class Portfolio
    {
        public Portfolio()
        {
            StavkePortfolia = new HashSet<StavkePortfolium>();
        }

        public int PortfolioId { get; set; }
        public string Opis { get; set; }
        public int? UposlenikId { get; set; }

        public virtual Uposlenik Uposlenik { get; set; }
        public virtual ICollection<StavkePortfolium> StavkePortfolia { get; set; }
    }
}
