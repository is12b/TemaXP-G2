using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public interface IArtPieceDb {
        void Add(ArtPiece art);

        List<ArtPiece> GetAll();

        void Update(ArtPiece auc);

        void Delete(int id);

        ArtPiece GetById(int id);
    }
}
