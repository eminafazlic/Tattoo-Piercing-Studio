using System;
using System.ComponentModel.DataAnnotations;

namespace TattooStudio.Model.Requests
{
    public class StavkePortfoliumInsertRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        public int? PortfolioId { get; set; }
        
        public byte[] Slika { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        [MaxLength(100, ErrorMessage = "Maksimalna dužina ovog polja je 100 znakova")]
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
    }
}
