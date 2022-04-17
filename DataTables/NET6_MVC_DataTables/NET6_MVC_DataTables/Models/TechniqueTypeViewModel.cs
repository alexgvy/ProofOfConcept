
using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class TechniqueTypeViewModel : CreateOrUpdateBaseViewModel
    {
        public int? TechniqueTypeId { get; set; } = null;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(50, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(50, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;

        public List<TechniqueTypeViewModel> TechniqueTypeList { get; set; } = new List<TechniqueTypeViewModel>();

        public List<TechniqueSubTypeViewModel> TechniqueSubTypeList { get; set; } = new List<TechniqueSubTypeViewModel>();
    }
}
