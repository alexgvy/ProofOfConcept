using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class TechniqueSubTypeViewModel : CreateOrUpdateBaseViewModel
    {
        public int? TechniqueSubTypeId { get; set; } = null;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Select a Technique")]
        public int? TechniqueTypeId { get; set; } = null;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(50, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(50, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
        public List<TechniqueTypeViewModel> TechniqueTypeList { get; set; } = new List<TechniqueTypeViewModel>();
    }
}
