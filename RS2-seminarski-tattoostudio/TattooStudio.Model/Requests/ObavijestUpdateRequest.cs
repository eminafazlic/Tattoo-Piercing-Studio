using System.ComponentModel.DataAnnotations;

namespace TattooStudio.Model.Requests
{
    public class ObavijestUpdateRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        [MinLength(3, ErrorMessage = "Minimalna dužina ovog polja je 3 znaka")]
        [MaxLength(50, ErrorMessage = "Maksimalna dužina ovog polja je 50 znakova")]
        public string Naslov { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Obavezno polje")]
        [MinLength(3, ErrorMessage = "Minimalna dužina ovog polja je 3 znaka")]
        [MaxLength(500, ErrorMessage = "Maksimalna dužina ovog polja je 500 znakova")]
        public string Sadrzaj { get; set; }
    }
}
