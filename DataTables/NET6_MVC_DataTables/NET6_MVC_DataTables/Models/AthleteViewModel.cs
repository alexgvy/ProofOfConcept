
using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class AthleteViewModel : CreateOrUpdateBaseViewModel
    {
        public int AthleteId { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthTwentyFive, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblBeltLengthTwentyFive, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [MaxLength(SharedConstants.TblAthleteNickLengthSixty, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Nick Name")]
        public string? NickName { get; set; }

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Select the Athlete's belt")]
        public int BeltRankId { get; set; }

        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Biography")]
        public string Bio { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Please, enter a valid email address.")]
        [MaxLength(SharedConstants.TblAthleteNickLengthSixty, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Email Address (optional)")]
        public string? EmailAddress { get; set; }

        public List<BeltRankViewModel> BeltRankList { get; set; } = new List<BeltRankViewModel>();

        public string FullName { get { return $"{LastName}, {FirstName}"; } }
    }
}
