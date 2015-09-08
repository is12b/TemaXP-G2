using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCFBusinessLogic.Model {
    [DataContract(IsReference = true) ]
     public class ArtPiece {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int ArtPieceId { get; set; }
        [DataMember]
        [Required]
         public int Number { get; set; }
        [DataMember]
        [Required]
        [MaxLength(40), MinLength(1)]
         public string Name { get; set; }
        [DataMember]
        [MaxLength(80)]
         public string Description { get; set; }
        [DataMember]
        [MaxLength(40)]
         public string Artist { get; set; }
        [DataMember]
         public string PictureUrl { get; set; }
        [DataMember]
        [Range(0, 9999)]
        [Required]
         public int PurchasePrice { get; set; }
        [DataMember]
        public Lot Lot { get; set; }
        [DataMember]
        public int LotId { get; set; }

    }
}
