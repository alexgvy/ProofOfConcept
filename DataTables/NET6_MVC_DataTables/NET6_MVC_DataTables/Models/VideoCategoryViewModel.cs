using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class VideoCategoryViewModel : CreateOrUpdateBaseViewModel
    {
        public int? VideoCategoryId { get; set; } = null;

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthThirty, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblVideoDescriptionLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Culture")]
        public string Description { get; set; } = null!;
    }
}
