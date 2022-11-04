using System.ComponentModel.DataAnnotations;

namespace Lesson5.Models
{
    public class Ogrenci
    {
        [Required(ErrorMessage = "No Zorunlu")]
        [Display(Name = "Ogrenci No")]
        public int OgrNo { get; set; }
        [Display(Name = "Ogrenci No")]
        public string OgrAd { get; set; }
        [Display(Name = "Ogrenci No")]
        public string OgrSoyad { get; set; }
    }
}
