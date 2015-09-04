using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFBusinessLogic.Model {
    [DataContract(IsReference = true)]
    public class Bid {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BidId { get; set; }
        [DataMember]
        [Required]
        public int Amount { get; set; }
        [DataMember]
        [Required]
        public Member Bidder { get; set; }
    }
}
