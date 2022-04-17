using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class VideoSerieViewModel : CreateOrUpdateBaseViewModel
    {
        public int? VideoSeriesId { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthThirty, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblVideoDescriptionLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Price")]
        //[Range(1, 500)]
        [DataType(DataType.Currency)]
        public decimal OriginalPrice { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Promotional Price")]
        //[Range(1, 500)]
        [DataType(DataType.Currency)]
        public decimal ActualPrice { get; set; }
        [Display(Name = "Promotional Text")]
        [MaxLength(SharedConstants.TblVideoImageUrlLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        public string? PromotionalText { get; set; }

        public IFormFile? Thumbnail { get; set; }

        [MaxLength(SharedConstants.TblVideoImageUrlLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        public string? ImageUrl { get; set; }
        public List<VideoViewModel>? VideoList { get; set; } = new List<VideoViewModel>();
    }
}
