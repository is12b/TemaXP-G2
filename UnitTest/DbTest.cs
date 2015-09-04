using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFBusinessLogic.Model;

namespace UnitTest {
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class DbTest {
        public DbTest() {
            
        }

        private AuctionContext _auctionContext = new AuctionContext();


       
        [TestMethod]
        public void TestDb() {
            Member m = new Member();
            _auctionContext.Members.Add(m);
            _auctionContext.SaveChanges();
            var list = _auctionContext.Members.ToList();
            Console.WriteLine(list[0].MemberId);
            Assert.AreNotEqual(0, list.Count);

        }
    }
}
