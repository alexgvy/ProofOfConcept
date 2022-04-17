using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class VideoLanguageViewModel : CreateOrUpdateBaseViewModel
    {
        public int? VideoLanguageId { get; set; } = null;

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthTen, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthTen, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Culture")]
        public string Culture { get; set; } = null!;
    }
}
