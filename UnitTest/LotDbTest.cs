using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Model;

namespace UnitTest {
    [TestClass]
    public class LotDbTest {
        #region Init

        private Mock<DbSet<Auction>> _auctionMock;
        private Mock<DbSet<Lot>> _lotMock;
        private Mock<DbSet<ArtPiece>> _artPieceMock;
        private Mock<AuctionContext> _mockContext;

        private ArtPiece _artPiece;
        private Lot _lot;
        private Auction _auction;

        [TestInitialize]
        public void Initialize() {}


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
                ArtPiece = _artPiece,
                AuctionId =  1
            };

            _auction = new Auction {
                AuctionId = 1,
                AuctionName = "Test Auction",
                CreationDate = DateTime.Now,
                LotDuration = TimeSpan.FromMinutes(30),
                Multiplier = 3,
                Status = Status.Ready,
                Lots = new List<Lot>() {_lot}
            };

            _lot.Auction = _auction;



            var data = new List<Lot> {
                _lot
            }.AsQueryable();

            _lotMock.As<IQueryable<Lot>>().Setup(m => m.Provider).Returns(data.Provider);
            _lotMock.As<IQueryable<Lot>>().Setup(m => m.Expression).Returns(data.Expression);
            _lotMock.As<IQueryable<Lot>>().Setup(m => m.ElementType).Returns(data.ElementType);
            _lotMock.As<IQueryable<Lot>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        }

        #endregion

        [TestMethod]
        public void AddTest() {
            try {
                Test();
                var lotCtr = new LotDb(_mockContext.Object);

                lotCtr.Add(_lot);

                _lotMock.Verify(m => m.Add(It.IsAny<Lot>()), Times.Once());
                _mockContext.Verify(m => m.SaveChanges(), Times.Once());
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetAllByAuctionTest() {
            try {
                Test();
                var lotCtr = new LotDb(_mockContext.Object);

                var list = lotCtr.GetAllByAuction(_auction);

                Assert.AreNotEqual(0, list.Count);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void UpdateTest() {
            try {
                Test();
                var lotCtr = new LotDb(_mockContext.Object);

                _lot.MinBid = 50;

                lotCtr.Update(_lot);

                var list = lotCtr.GetAllByAuction(_auction);

                Assert.AreEqual(50, list[0].MinBid);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void DeleteTest() {
            try {
                Test();
                var lotCtr = new LotDb(_mockContext.Object);

                lotCtr.Delete(_lot.LotId);

                _lotMock.Verify(m => m.Remove(It.IsAny<Lot>()), Times.Once);
                _mockContext.Verify(m => m.SaveChanges(), Times.Once);

                Assert.IsTrue(true);
            }
            catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetByIdTest() {
            bool test = false;
            try {
                Test();
                var lotCtr = new LotDb(_mockContext.Object);

                var lot = lotCtr.GetById(1);

                test = true;

                lotCtr.GetById(2);

            }
            catch (NullReferenceException) {
                if (!test) {
                    Assert.Fail();
                }
                else {
                    Assert.IsTrue(true);
                }
            }
            catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }

    }
}
