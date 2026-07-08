using System.ComponentModel.DataAnnotations;

namespace BlazorTraining.Domain.ViewModels
{
    public class CreateServerViewModel
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string Region { get; set; }

        [Required]
        public bool ActiveStatus { get; set; } = false;
    }
}
