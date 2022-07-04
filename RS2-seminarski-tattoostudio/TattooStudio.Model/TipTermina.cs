using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class TipTermina
    {
        public int TipTerminaId { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
    
}
