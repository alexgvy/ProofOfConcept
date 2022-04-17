namespace NET6_MVC_DataTables.Models
{
    public class CreateOrUpdateBaseViewModel
    {
        public bool DisplayErrorMessage { get; set; }

        public bool DisplaySuccessMessage { get; set; }

        public string StatusMessage { get; set; } = String.Empty;

        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastUpdatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
