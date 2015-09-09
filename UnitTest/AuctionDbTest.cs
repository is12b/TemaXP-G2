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
                Bidder = new Member() { MemberId = 1},
                BidId = 1
            };

            _bidLot = new Lot() {
                LotId = 2,
                MinBid = 20,
                Position = 1,
                ArtPiece = _bidArtPiece,
                Bids = new List<Bid>() { bid}
            };

            _bidAuction = new Auction {
                AuctionId = 5,
                AuctionName = "Test Auction",
                CreationDate = DateTime.Now,
                LotDuration = TimeSpan.FromMinutes(30),
                Multiplier = 3,
                Status = Status.Ongoing,
                Lots = new List<Lot>() { _bidLot }
            };


            _auctionMock.AddQueryData(new List<Auction> { _auction, _bidAuction }.AsQueryable());

        }

        #endregion

        [TestMethod]
        public void AddTest() {
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                auctionCtr.Add(_auction);

                _auctionMock.Verify(m => m.Add(It.IsAny<Auction>()), Times.Once());
                _mockContext.Verify(m => m.SaveChanges(), Times.AtMost(2));
            } catch (Exception e) {
                Console.WriteLine(e);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetAllReadyTest() {
            try {
                Test();
                var auctionCtr = new AuctionDb(_mockContext.Object);

                var list = auctionCtr.GetAllReady();

                Assert.AreEqual(1, list.Count);
            }
            catch (Exception ex) {
                ex.DebugGetLine();
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
                Console.WriteLine(list[0].Lots.Count);

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

                auctionCtr.Delete(_bidAuction.AuctionId);
                _lotMock.Verify(m => m.RemoveRange(It.IsAny<List<Lot>>()), Times.Once);
                _auctionMock.Verify(m => m.Remove(It.IsAny<Auction>()), Times.Once);
                _mockContext.Verify(m => m.SaveChanges(), Times.Exactly(2));

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
