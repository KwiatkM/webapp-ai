using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wiadomość jest wymagana")]
        public string Message { get; set; }
    }
}
