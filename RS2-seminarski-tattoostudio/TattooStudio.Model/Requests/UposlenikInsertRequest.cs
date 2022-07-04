using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TattooStudio.Model.Requests
{
    public class UposlenikInsertRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        [MinLength(3, ErrorMessage = "Minimalna dužina ovog polja je 3 znaka")]
        [MaxLength(20, ErrorMessage = "Maksimalna dužina ovog polja je 20 znakova")]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Dozvoljen unos samo slova")]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        [MinLength(3, ErrorMessage = "Minimalna dužina ovog polja je 3 znaka")]
        [MaxLength(30, ErrorMessage = "Maksimalna dužina ovog polja je 30 znakova")]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Dozvoljen unos samo slova")]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Obavezno polje")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obavezno polje!")]
        [RegularExpression("\\d{3}\\/\\d{3}-\\d{3,4}", ErrorMessage = "Format: XXX/XXX-XXX ili XXX/XXX-XXXX")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Obavezno polje!", AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        [Range(1, 3)]
        [Required(ErrorMessage = "Obavezno polje")]
        public int? SpolId { get; set; }
        
        public byte[] Slika { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        public int ZanimanjeId { get; set; }
        [Required(ErrorMessage = "Obavezno polje!", AllowEmptyStrings = false)]
        public string Lozinka { get; set; }
        [Required(ErrorMessage = "Obavezno polje!", AllowEmptyStrings = false)]
        public string PotvrdiLozinku { get; set; }
    }
}
