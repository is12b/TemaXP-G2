using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFService {
    [ServiceContract]
    public interface IMemberService {
        [OperationContract]
        List<Member> GetAllMembers();

        [OperationContract]
        Member GetMemberById(int id);
        
    }
}
