using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFBusinessLogic.Model {
    [DataContract]
    public enum Status {
        [EnumMember]
        Ready,
        [EnumMember]
        Ongoing,
        [EnumMember]
        Complete,
    }
}