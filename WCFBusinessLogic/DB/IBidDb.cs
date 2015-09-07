using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public interface IBidDb {

        void Add(Bid bid);

        List<Bid> GetAllByLot(Lot lot);
    }
}
