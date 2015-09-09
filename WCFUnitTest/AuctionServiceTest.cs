using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFUnitTest.MainServiceReference;

namespace WCFUnitTest {
    [TestClass]
    public class AuctionServiceTest {
        MainServiceReference.IAuctionService _auctionService = new AuctionServiceClient();
        [TestMethod]
        public void AddAuctionTest() {
            try {
                _auctionService.AddAuction(new Auction() {
                    AuctionName = "&!/(#"                    
                });
                Assert.Fail("Regex failed");
            }
            catch (Exception e) {
                e.DebugGetLine();
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void UpdateAuctionTest() {
            try {
                _auctionService.UpdateAuction(new Auction() {
                    AuctionName = "/!&%"
                });
                Assert.Fail("Regex failed on update");
            }
            catch (Exception e) {
                e.DebugGetLine();
                Assert.IsTrue(true);
            }
        }
    }
}
