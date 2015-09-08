using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFBusinessLogic.Model {
    [DataContract(IsReference = true)]
    public class Member {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId {
            get;
            set;
        }

        [DataMember]
        public string Name {
            get;
            set;
        }

        [DataMember]
        public string Department {
            get;
            set;
        }

        [DataMember]
        public string Cpr {
            get;
            set;
        }

        [DataMember]
        public string Address {
            get;
            set;
        }

        [DataMember]
        public string Email {
            get;
            set;
        }

        [DataMember]
        public int Points {
            get;
            set;
        }
    }
}
