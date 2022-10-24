using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace McfBeApp.Api.Model
{
    [Table("ms_storage_location")]
    public class StorageLocation
    {
        [Key]
        [Column(name: "location_id", TypeName = "VARCHAR")]
        [MaxLength(10)]
        public string? LocationId { get; set; }

        [Column(name: "location_name", TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string? LocationName { get; set; }
    }
}
