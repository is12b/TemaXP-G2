using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public interface IAuctionDb {

        void Add(Auction ac);

        List<Auction> GetAll();

        void Update(Auction auc);

        void Delete(int id);

        Auction GetById(int id);
    }
}
