using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Lesson4.Models
{
    public class Ogrenci
    {
        [Display(Name = "Öğrenci Ad")]
        [Required(ErrorMessage = "Alanı Doldurunuz.")]
        public string OgrAd { get; set; }
        [Display(Name = "Öğrenci Soyad")]
        public string OgrSoyad { get; set; }
        [Display(Name = "Öğrenci No")]
        public string OgrNo { get; set; }
        [Display(Name = "Öğrenci Yaşı")]
        public int OgrYas { get; set; }
        [Display(Name = "Şehirler")]
        public string Sehirler { get; set; }

   
    }
}
