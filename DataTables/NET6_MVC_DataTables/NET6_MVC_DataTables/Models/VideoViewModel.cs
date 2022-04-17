using System.ComponentModel.DataAnnotations;

namespace NET6_MVC_DataTables.Models
{
    public class VideoViewModel : CreateOrUpdateBaseViewModel
    {
        public int VideoId { get; set; }
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblVideoTitleLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Title")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [MaxLength(SharedConstants.TblVideoDescriptionLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "The '{0}' field is required.")]
        [Display(Name = "Year")]
        public short? Year { get; set; } //#A
        [Required(ErrorMessage = "The '{0}' field is required.")]




        //[Required(ErrorMessage = "The '{0}' field is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]//,
                                 //DataType(DataType.Currency)]//,
                                 //DisplayFormat(NullDisplayText = "-",
                                 //    ApplyFormatInEditMode = true,
                                 //    DataFormatString = "{0:C}")]
        public decimal? OriginalPrice { get; set; } //#A
                                                    // [Required(ErrorMessage = "The '{0}' field is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Promotional Price")]//,
                                             //DataType(DataType.Currency)]//,
                                             //DisplayFormat(NullDisplayText = "-",
                                             //    ApplyFormatInEditMode = true,
                                             //    DataFormatString = "{0:C}")]
        public decimal? ActualPrice { get; set; } //#A
        [MaxLength(SharedConstants.TblVideoPromotionalTextLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        [Display(Name = "Promotional Text")]
        public string? PromotionalText { get; set; }
        [MaxLength(SharedConstants.TblVideoImageUrlLength, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        public string? ImageUrl { get; set; }
        public int ReviewsCount { get; set; }
        public double ReviewsAverageVotes { get; set; }

        public string? ResourceGroupName { get; set; }
        public string? AccountName { get; set; }
        public string? InputAssetName { get; set; }
        public bool? StopEndpoint { get; set; }
        public string? StreamingEndpointName { get; set; }


        //public List<TechniqueTypeDto> TechniqueTypeList { get; set; }
        public List<TechniqueViewModel> TechniqueList { get; set; } = new List<TechniqueViewModel>();
        public List<TechniqueTypeViewModel> TechniqueTypeList { get; set; } = new List<TechniqueTypeViewModel>();
        public List<TechniqueSubTypeViewModel> TechniqueSubTypeList { get; set; } = new List<TechniqueSubTypeViewModel>();

        [Display(Name = "Select a Technique Type")]
        public int? TechniqueTypeId { get; set; } = null;

        [Display(Name = "Select a Technique Sub-Type")]
        public int? TechniqueSubTypeId { get; set; } = null;

        [Display(Name = "Select a Technique")]
        public int? TechniqueId { get; set; } = null; //#A
                                                      //[Required(ErrorMessage = "The '{0}' field is required.")]

        [Display(Name = "Select the recommended belt rank for this video.")]
        public List<int> BeltRankIdList { get; set; } = new List<int>();
        public List<BeltRankViewModel> BeltRankList { get; set; } = new List<BeltRankViewModel>();

        [Display(Name = "Select the Athletes in this video")]
        [Required(ErrorMessage = "The '{0}' field is required.")]
        public List<int> AthleteIdList { get; set; } = new List<int>();
        public List<AthleteViewModel> AthletesList { get; set; } = new List<AthleteViewModel>();

        [Display(Name = "Select the target age group for this video")]
        [Required(ErrorMessage = "The '{0}' field is required.")]
        public List<int> AgeGroupIdList { get; set; } = new List<int>();
        public List<AgeGroupViewModel> AgeGroupList { get; set; } = new List<AgeGroupViewModel>();

        [Display(Name = "Select the target gender group for this video")]
        [Required(ErrorMessage = "The '{0}' field is required.")]
        public List<int> GenderGroupIdList { get; set; } = new List<int>();
        public List<GenderGroupViewModel> GenderGroupList { get; set; } = new List<GenderGroupViewModel>();



        [Display(Name = "Select a video series")]
        public int? VideoSeriesId { get; set; }

        public List<VideoSerieViewModel> VideoSeriesList { get; set; } = new List<VideoSerieViewModel>();
        [Display(Name = "Sequency Order Number")]
        public short? SequencyOrderNumber { get; set; }

        public string AthletesFieldValue
        {
            get
            {
                return string.Join(", ", AthletesList.Select(a => string.IsNullOrWhiteSpace(a.NickName) ? $"{a.FirstName} {a.LastName}" : $"{a.FirstName} {a.LastName} ({a.NickName})").ToList());
            }
        }


        public string? TokenCenc { get; set; }
        public string? TokenCbcs { get; set; }

        public string? KeyIdentifierCenc { get; set; }
        public string? KeyIdentifierCbcs { get; set; }

        private string _videoUrl;

        [MaxLength(1000, ErrorMessage = "The '{0}' entered is longer than {1} characters.")]
        public string VideoUrl
        {
            get
            {
                var finalUrl = string.Empty;
                if (!string.IsNullOrWhiteSpace(_videoUrl))
                {
                    var urlList = _videoUrl.Split('|');
                    if (urlList.Any())
                    {
                        var manifest = "/manifest";
                        var tempUrlList = urlList.First().Split(manifest);
                        if (tempUrlList.Any())
                        {
                            if (!string.IsNullOrWhiteSpace(tempUrlList[0]))
                            {
                                finalUrl = tempUrlList[0] + manifest;
                            }
                        }
                    }
                }
                return finalUrl;
            }
            set { _videoUrl = value; }
        }

        private string? _transcriptUrl;
        public string? TranscriptUrl
        {
            get
            {
                return _transcriptUrl;
                //var finalUrl = string.Empty;
                //if (!string.IsNullOrWhiteSpace(_videoUrl))
                //{
                //    var urlList = _videoUrl.Split('|');
                //    if (urlList.Any())
                //    {
                //        var manifest = "/manifest";
                //        var tempUrlList = urlList.First().Split(manifest);
                //        if (tempUrlList.Any())
                //        {
                //            if (!string.IsNullOrWhiteSpace(tempUrlList[0]))
                //            {
                //                var indexOfBar = tempUrlList[0].LastIndexOf('/');

                //                var baseUrl = tempUrlList[0].Substring(0, indexOfBar);

                //                finalUrl = $"{baseUrl}/transcript.vtt";// baseUrl + manifest;
                //            }
                //        }
                //    }
                //}
                //return finalUrl;
            }
            set { _transcriptUrl = value; }
        }

        public string? DefaultThumbnailUrl { get; set; }

        public IFormFile? Thumbnail { get; set; }

        public IFormFile? VideoFile { get; set; }

        [Required(ErrorMessage = "The '{0}' field is required.")]

        [Display(Name = "Select a video language")]
        public int? VideoLanguageId { get; set; }

        public List<VideoLanguageViewModel> VideoLanguageList { get; set; } = new List<VideoLanguageViewModel>();

        public List<VideoAthleteDto> VideoAthletes { get; set; } = new();
        public List<VideoAgeGroupDto> VideoAgeGroups { get; set; } = new();
        public List<VideoGenderGroupDto> VideoGenderGroups { get; set; } = new();
        public List<VideoBeltRankDto> VideoBeltRanks { get; set; } = new();

        public string? Notes { get; set; }
    }
}
