using System.ComponentModel.DataAnnotations;

namespace FreelanceCore.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        [Phone]
        [Display(Name = "No Telepon")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
