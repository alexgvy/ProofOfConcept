namespace NET6_MVC_DataTables.Models
{
    public class GenderGroupViewModel : CreateOrUpdateBaseViewModel
    {
        public int GenderGroupId { get; set; }
        public string Name { get; set; } = null!;
    }
}
