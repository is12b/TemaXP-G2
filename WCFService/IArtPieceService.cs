using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFService {
    [ServiceContract]
    public interface IArtPieceService {
        [OperationContract]
        void AddArtPiece(ArtPiece piece);

        [OperationContract]
        List<ArtPiece> GetAllArtPieces();

        [OperationContract]
        void UpdateArtPiece(ArtPiece piece);

        [OperationContract]
        void DeleteArtPiece(int id);

        [OperationContract]
        ArtPiece GetArtPieceById(int id);

        [OperationContract]
        List<ArtPiece> GetAllAvilableArtPieces();

    }


}
