using System;
using System.Collections.Generic;
using System.Text;

namespace TattooStudio.Model.SearchObjects
{
    public class TerminSearchObject
    {
        public bool? IsOdobren { get; set; }
        public bool? IsPlacen { get; set; }
        public bool? IsOtkazan { get; set; }
        public DateTime? Datum { get; set; }
        public int? UposlenikId { get; set; }
        public int? KlijentId { get; set; }
        public bool? NadolazeciTermini { get; set; }
    }
}
