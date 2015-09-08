using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Model;

namespace WCFService {
    public class ArtPieceService : IArtPieceService {
        private IArtPieceDb _artDb = new ArtPieceDb();

        public void Add(ArtPiece piece) {
            String regName = "^[a - zA - Z0 - 9]{ 4,10}$";
            if (piece.Number <= 0 || piece.Name.Length <= 0)
                throw new ArgumentException();
            if (Regex.IsMatch(piece.Name, regName) || Regex.IsMatch(piece.Description, regName))
                throw new ArgumentException();

            _artDb.Add(piece);
        }

        public void Delete(int id) {
            _artDb.Delete(id);
        }

        public List<ArtPiece> GetAll() {
            return _artDb.GetAll();
        }

        public ArtPiece GetById(int id) {
            return _artDb.GetById(id);
        }

        public void Update(ArtPiece piece) {
            String regName = "^[a - zA - Z0 - 9]{ 4,10}$";
            if (piece.Number <= 0 || piece.Name.Length <= 0)
                throw new ArgumentException();
            if (Regex.IsMatch(piece.Name, regName) || Regex.IsMatch(piece.Description, regName))
                throw new ArgumentException();
            _artDb.Update(piece);
        }
    }
}
