using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Helper;
using WCFBusinessLogic.Model;

namespace UnitTest
{
    [TestClass]
    public class SetUpDB
    {

        private Random rand = new Random();

        [TestMethod]
        public void CreateStuff() {
            ArtPieceDb _db = new ArtPieceDb();
            for (int i = 0; i < 20; i++) {
                _db.Add(GetRandomArt());
            }
        }

        private ArtPiece GetRandomArt() {
            var _artPiece = new ArtPiece() {
                Artist = "Anders",
                Description = "Hej",
                Name = "Mona Lisa",
                Number = rand.Next(1001, 9999),
                PurchasePrice = rand.Next(100, 1000)
            };

            return _artPiece;
        }
        
        [TestMethod]
        public void DatabaseCreatedTest()
        {
            try
            {
                AuctionContext ac = new AuctionContext();

                ac.Members.ToList();

                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                e.DebugGetLine();
                Assert.Fail();
            }
        }
    }
}
