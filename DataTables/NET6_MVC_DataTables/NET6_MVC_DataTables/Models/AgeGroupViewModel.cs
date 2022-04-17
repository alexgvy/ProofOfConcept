namespace NET6_MVC_DataTables.Models
{
    public class AgeGroupViewModel : CreateOrUpdateBaseViewModel
    {
        public int AgeGroupId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public short StartAge { get; set; }
        public short EndAge { get; set; }
    }
}
