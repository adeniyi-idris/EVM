using System.ComponentModel.DataAnnotations;

namespace EventMgtApp.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
