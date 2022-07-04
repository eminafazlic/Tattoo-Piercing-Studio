using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model
{
    public class Spol
    {
        public int SpolId { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
