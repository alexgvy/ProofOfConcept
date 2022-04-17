using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6_MVC_DataTables.Models
{
    public class VideoAgeGroupDto
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int AgeGroupId { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastUpdatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
