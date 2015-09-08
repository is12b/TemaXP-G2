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
        void AddLot(Lot lot);

        [OperationContract]
        List<Lot> GetAllLotsByAuction(Auction auction);

        [OperationContract]
        void UpdateLot(Lot lot);

        [OperationContract]
        void DeleteLot(int id);

        [OperationContract]
        Lot GetLotById(int id);
    }
}
