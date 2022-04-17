using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class BeltRankViewModel : CreateOrUpdateBaseViewModel
    {
        public int BeltRankId { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthTen, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]

        [Display(Name = "Weight of the belt")]
        public short? RankWeight { get; set; }
    }
}
