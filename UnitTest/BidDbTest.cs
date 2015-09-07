using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Helper;
using WCFBusinessLogic.Model;

namespace UnitTest {
  
    [TestClass]
    public class BidDbTest {

        #region Init

        private Mock<DbSet<Auction>> _auctionMock;
        private Mock<DbSet<Lot>> _lotMock;
        private Mock<DbSet<ArtPiece>> _artPieceMock;
        private Mock<DbSet<Bid>> _bidMock;
        private Mock<AuctionContext> _mockContext;

        private ArtPiece _artPiece;
        private ArtPiece _bidArtPiece;
        private Lot _lot;
        private Lot _bidLot;
        private Auction _auction;
        private Auction _bidAuction;

        [TestInitialize]
        public void Initialize() {
        }


        private void Test() {
            _auctionMock = new Mock<DbSet<Auction>>();
            _lotMock = new Mock<DbSet<Lot>>();
            _artPieceMock = new Mock<DbSet<ArtPiece>>();
            _bidMock = new Mock<DbSet<Bid>>();
            _mockContext = new Mock<AuctionContext>();

            _mockContext.Setup(m => m.Auctions).Returns(_auctionMock.Object);
            _mockContext.Setup(m => m.Lots).Returns(_lotMock.Object);
            _mockContext.Setup(m => m.ArtPieces).Returns(_artPieceMock.Object);
            _mockContext.Setup(m => m.Bids).Returns(_bidMock.Object);

            _artPiece = new ArtPiece() {
                ArtPieceId = 1,
                Artist = "Anders",
                Description = "Hej",
                Name = "Mona Lisa",
                Number = 1001,
                PurchasePrice = 10
            };

            _lot = new Lot() {
                LotId = 1,
                MinBid = 20,
                Position = 1,
                ArtPiece = _artPiece
            };

            _auction = new Auction {
                AuctionId = 1,
                AuctionName = "Test Auction",
                CreationDate = DateTime.Now,
                LotDuration = TimeSpan.FromMinutes(30),
                Multiplier = 3,
                Status = Status.Ready,
                Lots = new List<Lot>() { _lot }
            };

            _bidArtPiece = new ArtPiece() {
                ArtPieceId = 2,
                Artist = "Anders",
                Description = "Hej",
                Name = "Mona Lisa",
                Number = 1001,
                PurchasePrice = 10
            };



            Bid bid = new Bid() {
                Amount = 20,
                Bidder = new Member() { MemberId = 1 },
                BidId = 1
            };

            _bidLot = new Lot() {
                LotId = 2,
                MinBid = 20,
                Position = 1,
                ArtPiece = _bidArtPiece,
                Bids = new List<Bid>() { bid }
            };

            _bidAuction = new Auction {
                AuctionId = 5,
                AuctionName = "Test Auction",
                CreationDate = DateTime.Now,
                LotDuration = TimeSpan.FromMinutes(30),
                Multiplier = 3,
                Status = Status.Ready,
                Lots = new List<Lot>() { _bidLot }
            };


            _auctionMock.AddQueryData(new List<Auction> { _auction, _bidAuction }.AsQueryable());

        }

        #endregion

        [TestMethod]
        public void AddTest() {
            try {
                Test();
                var bidCtr = new BidDb(_mockContext.Object);

                bidCtr.Add(new Bid() {
                    Amount = 20,
                    Bidder = new Member() {MemberId = 2},
                    BidId = 2,
                    LotId = _bidLot.LotId
                });


                _bidMock.Verify(m => m.Add(It.IsAny<Bid>()), Times.Once);
                _mockContext.Verify(m => m.SaveChanges(), Times.Once);
                Assert.IsTrue(true);
            }
            catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetAllByLotTest() {
            try {
                Test();
                var bidCtr = new BidDb(_mockContext.Object);

                var list = bidCtr.GetAllByLot(_bidLot);

                if (list.Count > 0) {
                    Assert.IsTrue(true);
                }
                else {
                    Assert.Fail();
                }
            }
            catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }
        
    }
}
