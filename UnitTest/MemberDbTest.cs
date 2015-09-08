using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WCFBusinessLogic.Helper;
using WCFBusinessLogic.Model;
using WCFBusinessLogic.DB;

namespace UnitTest {
    [TestClass]
    public class MemberDbTest {

        #region Init

        private Mock<DbSet<Member>> _mockMember;
        private Mock<AuctionContext> _mockContext;


        private void Test() {
            _mockMember = new Mock<DbSet<Member>>();
            _mockContext = new Mock<AuctionContext>();

            _mockContext.Setup(m => m.Members).Returns(_mockMember.Object);

            var _member = new Member() {
                MemberId = 1,
                Address = "Hej",
                Name = "Lasse",
                Cpr = "101010101010",
                Department = "UCN",
                Email = "Hej@hej.hej",
                Points = 900
            };

            var _member2 = new Member() {
                MemberId = 2,
                Address = "Hej",
                Name = "Lasse",
                Cpr = "101010101010",
                Department = "UCN",
                Email = "Hej@hej.hej",
                Points = 500
            };



            _mockMember.AddQueryData(new List<Member> { _member, _member2 }.AsQueryable());

        }

        #endregion




        [TestMethod]
        public void GetAllTest() {
            try {
                Test();

                var memberCtr = new MemberDb(_mockContext.Object);

                var list = memberCtr.GetAll();

                if (list.Count > 1) {
                    Assert.IsTrue(true);
                } else {
                    Assert.Fail();
                }


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

                var memberCtr = new MemberDb(_mockContext.Object);

                var mem = memberCtr.GetById(1);

                test = true;

                memberCtr.GetById(1);

            } catch (NullReferenceException) {
                if (test)
                    Assert.IsTrue(true);

                if (!test)
                    Assert.Fail();
            } catch (Exception e) {
                e.DebugGetLine();
                Assert.Fail();
            }
        }
    }
}
