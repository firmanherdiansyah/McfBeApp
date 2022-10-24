using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace McfBeApp.Api.Model
{
    [Table("tr_bpkb")]
    public class BpkpTransaction
    {
        [Key]
        [Column(name: "agreement_number", TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string? AgrrementNumber { get; set; }

        [Column(name: "bpkb_number", TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string? BpkbNumber { get; set; }


        [Column(name: "bpkp_date")]
        public DateTime BpkbDate { get; set; }

        [Column(name: "faktur_date")]
        public DateTime FakturDate { get; set; }

        [Column(name: "location_id", TypeName = "VARCHAR")]
        [MaxLength(10)]
        [ForeignKey("StorageLocation")]
        public string? LocationId { get; set; }
        public StorageLocation? StorageLocation { get; set; }

        [Column(name: "police_no", TypeName = "VARCHAR")]
        [MaxLength(20)]
        public string? PoliceNumber { get; set; }

        [Column(name: "bpkp_date_in")]
        public DateTime BpkbDateIn { get; set; }

    }
}
