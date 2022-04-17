using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class TechniqueViewModel : CreateOrUpdateBaseViewModel
    {
        public int? TechniqueId { get; set; } = null;

        [Display(Name = "Select a Technique Type")]
        public int TechniqueTypeId { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Select a Technique Sub-Type")]
        public int TechniqueSubTypeId { get; set; }

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(50, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(50, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Description")]
        public string? Description { get; set; }


        public List<TechniqueTypeViewModel> TechniqueTypeList { get; set; } = new List<TechniqueTypeViewModel>();
        public List<TechniqueSubTypeViewModel> TechniqueSubTypeList { get; set; } = new List<TechniqueSubTypeViewModel>();
    }
}
