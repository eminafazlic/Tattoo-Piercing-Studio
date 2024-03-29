﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class StavkeNarudzbe
    {
        public int StavkeNarudzbeId { get; set; }
        public int? NarudzbaId { get; set; }
        public int? ProizvodId { get; set; }
        public int? Kolicina { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
