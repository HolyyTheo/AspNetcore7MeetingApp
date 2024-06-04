using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim Bilgisi Zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon Bilgisi Zorunludur.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Mail Bilgisi Zorunludur.")]
        [EmailAddress(ErrorMessage = "Hatalı Mail Bilgisi.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katılım Bilgisi Zorunludur.")]
        public bool WillAttend { get; set; }
    }
}