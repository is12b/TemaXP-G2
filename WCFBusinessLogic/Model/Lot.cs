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
    public class Lot {

        public Lot() {
            Bids = new List<Bid>();
        }

        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LotId {
            get;
            set;
        }

        [DataMember]
        [Required]
        public int MinBid {
            get;
            set;
        }

        [DataMember]
        [Required]
        public int Position {
            get;
            set;
        }

        [DataMember]
        [Required]
        public ArtPiece ArtPiece {
            get;
            set;
        }

        [DataMember]
        public List<Bid> Bids {
            get;
            set;
        }
    }
}