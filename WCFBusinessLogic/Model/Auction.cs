using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFBusinessLogic.Model {
    [DataContract(IsReference = true)]
    public class Auction {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuctionId { get; set; }
        [DataMember]
        [Required]
        public string AuctionName { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        [Required]
        public Status Status { get; set; }
        [DataMember]
        [Required]
        public int Multiplier { get; set; }
        [DataMember]
        [Required]
        public TimeSpan LotDuration { get; set; }
        [DataMember]
        [Required]
        public List<Lot> Lots { get; set; }
    }
}