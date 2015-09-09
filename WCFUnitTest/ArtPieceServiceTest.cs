using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFBusinessLogic.Helper;
using WCFUnitTest.MainServiceReference;

namespace WCFUnitTest {
    [TestClass]
    public class ArtPieceServiceTest {

        MainServiceReference.IArtPieceService _artPieceService = new ArtPieceServiceClient();
        [TestMethod]
        public void AddArtPieceTest() {

            try {
                _artPieceService.AddArtPiece(new ArtPiece() {
                    Artist = "%/!",
                    Name = "/&()",
                    Description = "&/!",
                    Number = 1,
                    PictureUrl = "www.pornhub.com",
                    PurchasePrice = 12
                });
                Assert.Fail("Regex failed #ArtPiece");
            } catch (Exception e) {
                e.DebugGetLine();
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void UpdateArtPieceTest() {
            try {
                _artPieceService.UpdateArtPiece(new ArtPiece() {
                    Artist = "%/!",
                    Name = "/&()",
                    Description = "&/!",
                    Number = 1,
                    PictureUrl = "www.pornhub.com",
                    PurchasePrice = 12
                });
                Assert.Fail("Regex failed on Update");
            } catch (Exception e) {
                e.DebugGetLine();
                Assert.IsTrue(true);
            }
        }
    }
}
