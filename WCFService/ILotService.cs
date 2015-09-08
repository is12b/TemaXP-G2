using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFService {
    [ServiceContract]
    public interface ILotService {
        [OperationContract]
        void Add(Lot lot);

        [OperationContract]
        List<Lot> GetAllByAuction(Auction auction);

        [OperationContract]
        void Update(Lot lot);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        Lot GetById(int id);
    }
}
