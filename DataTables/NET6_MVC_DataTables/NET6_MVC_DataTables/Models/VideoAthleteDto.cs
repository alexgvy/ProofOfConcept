using System;
using System.Collections.Generic;

namespace NET6_MVC_DataTables.Models
{
    public partial class VideoAthleteDto
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int AthleteId { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastUpdatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
