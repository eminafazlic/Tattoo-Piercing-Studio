using System;
using System.ComponentModel.DataAnnotations;

namespace TattooStudio.Model.Requests
{
    public class TerminInsertRequest
    {
        [Required(ErrorMessage = "Obavezno polje", AllowEmptyStrings = false)]
        public int? KlijentId { get; set; }
        [Required(ErrorMessage = "Obavezno polje", AllowEmptyStrings = false)]
        public int? UposlenikId { get; set; }
        [Required(ErrorMessage = "Obavezno polje", AllowEmptyStrings = false)]
        public DateTime? Datum { get; set; }
        [Required(ErrorMessage = "Obavezno polje", AllowEmptyStrings = false)]
        [MinLength(10, ErrorMessage = "Minimalna dužina ovog polja je 10 znaka")]
        [MaxLength(200, ErrorMessage = "Maksimalna dužina ovog polja je 200 znakova")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Obavezno polje", AllowEmptyStrings = false)]
        public int? TipTerminaId { get; set; }
    }
}
