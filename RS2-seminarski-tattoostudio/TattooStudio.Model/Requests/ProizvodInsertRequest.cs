using System.ComponentModel.DataAnnotations;

namespace TattooStudio.Model.Requests
{
    public class ProizvodInsertRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        [MinLength(3, ErrorMessage = "Minimalna dužina ovog polja je 3 znaka")]
        [MaxLength(35, ErrorMessage = "Maksimalna dužina ovog polja je 35 znakova")]
        [RegularExpression("^[a-zA-Z0-9 šđžćč]*$", ErrorMessage = "Dozvoljen unos samo slova i brojeva")]

        public string Naziv { get; set; }
        [Range(1, 3)]
        [Required(ErrorMessage = "Obavezno polje")]
        public int? TipProizvodaId { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public double? Cijena { get; set; }
        [MinLength(3, ErrorMessage = "Minimalna dužina ovog polja je 3 znaka")]
        [MaxLength(40, ErrorMessage = "Maksimalna dužina ovog polja je 40 znakova")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        public string Opis { get; set; }
        
        public byte[] Slika { get; set; }
    }
}
