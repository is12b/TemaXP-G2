using System;
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
    public class AuctionDbTest {

        #region Init

        private Mock<DbSet<Auction>> _auctionMock;
        private Mock<DbSet<Lot>> _lotMock;
        private Mock<DbSet<ArtPiece>> _artPieceMock;
        private Mock<AuctionContext> _mockContext;

        private ArtPiece _artPiece;
        private Lot _lot;
        private Auction _auction;

        [TestInitialize]
        public void Initialize() {
        }


        private void Test() {
            _auctionMock = new Mock<DbSet<Auction>>();
            _lotMock = new Mock<DbSet<Lot>>();
            _artPieceMock = new Mock<DbSet<ArtPiece>>();
            _mockContext = new Mock<AuctionContext>();

            _mockContext.Setup(m => m.Auctions).Returns(_auctionMock.Object);
            _mockContext.Setup(m => m.Lots).Returns(_lotMock.Object);
            _mockContext.Setup(m => m.ArtPieces).Returns(_artPieceMock.Object);

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

            _auctionMock.AddQueryData(new List<Auction> { _auction }.AsQueryable());

        }

        #endregion

        [TestMethod]
        public void AddTest() {
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                auctionCtr.Add(_auction);

                _auctionMock.Verify(m => m.Add(It.IsAny<Auction>()), Times.Once());
                _mockContext.Verify(m => m.SaveChanges(), Times.Once());
            } catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetAllTest() {
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                var list = auctionCtr.GetAll();
                Console.WriteLine(list[0].AuctionName);

                Assert.AreNotEqual(0, list.Count);
            } catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void UpdateTest() {
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                _auction.AuctionName = "Kage";

                auctionCtr.Update(_auction);

                var list = auctionCtr.GetAll();

                Assert.AreEqual("Kage", list[0].AuctionName);
            } catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void DeleteTest() {
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                auctionCtr.Delete(_auction.AuctionId);

                _lotMock.Verify(m => m.RemoveRange(It.IsAny<List<Lot>>()), Times.Once);
                _auctionMock.Verify(m => m.Remove(It.IsAny<Auction>()), Times.Once);
                _mockContext.Verify(m => m.SaveChanges(), Times.Once);

                Assert.IsTrue(true);
            } catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetByIdTest() {
            bool test = false;
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                var ac = auctionCtr.GetById(1);

                test = true;

                auctionCtr.GetById(2);

            } catch (NullReferenceException) {
                if (!test) {
                    Assert.Fail();
                } else {
                    Assert.IsTrue(true);
                }
            } catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }

    }
}
