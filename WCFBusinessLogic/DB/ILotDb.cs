using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public interface ILotDb {

        void Add(Lot lot);

        List<Lot> GetAllByAuction(Auction ac);

        void Update(Lot lot);

        void Delete(int id);

        Lot GetById(int id);

    }
}
