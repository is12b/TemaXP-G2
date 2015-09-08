using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFService
{
    [ServiceContract]
    public interface IBidService {
        [OperationContract]
        void Add(Bid bid);
        [OperationContract]
        List<Bid> GetAllByLot(Lot lot);
    }
}
