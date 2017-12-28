using System.ComponentModel.DataAnnotations;

namespace FreelanceCore.Models.ManageViewModels
{
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password baru")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "Confirm password tidak sama.")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
