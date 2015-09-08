using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public interface IMemberDb {

        List<Member> GetAll();

        Member GetById(int id);

    }
}
