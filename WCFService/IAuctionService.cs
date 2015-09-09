using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFBusinessLogic.Model;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuctionService" in both code and config file together.
    [ServiceContract]
    public interface IAuctionService
    {
        [OperationContract]
        void AddAuction(Auction auction);
        [OperationContract]
        void UpdateAuction(Auction auction);

        [OperationContract]
        List<Auction> GetAllAuctions();

        [OperationContract]
        void DeleteAuction(int id);

        [OperationContract]
        Auction GetAuctionById(int id);

        [OperationContract]
        void StartLot(int time, Lot lot);

        [OperationContract]
        List<Auction> GetAllReady();
    }
   
}
