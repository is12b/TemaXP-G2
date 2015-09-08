using System.Collections.Generic;
using WCFBusinessLogic.Model;

namespace WCFService {
    public class MainService : IArtPieceService, IAuctionService, IBidService, ILotService, IMemberService {

        #region Instances

        private IArtPieceService _artPieceService = new ArtPieceService();

        private IAuctionService _auctionService = new AuctionService();

        private IBidService _bidService = new BidService();

        private ILotService _lotService = new LotService();

        private IMemberService _memberService = new MemberService();

        #endregion

        public void AddArtPiece(ArtPiece piece) {
            _artPieceService.AddArtPiece(piece);
        }

        public void AddAuction(Auction auction) {
            _auctionService.AddAuction(auction);
        }

        public void UpdateAuction(Auction auction) {
            _auctionService.UpdateAuction(auction);
        }

        List<Auction> IAuctionService.GetAllAuctions() {
            return _auctionService.GetAllAuctions();
        }

        Member IMemberService.GetMemberById(int id) {
            return _memberService.GetMemberById(id);
        }

        public void AddLot(Lot lot) {
            _lotService.AddLot(lot);
        }

        public List<Lot> GetAllLotsByAuction(Auction auction) {
            return _lotService.GetAllLotsByAuction(auction);
        }

        public void UpdateLot(Lot lot) {
            _lotService.UpdateLot(lot);
        }

        void ILotService.DeleteLot(int id) {
            _lotService.DeleteLot(id);
        }

        List<Member> IMemberService.GetAllMembers() {
            return _memberService.GetAllMembers();
        }

        Lot ILotService.GetLotById(int id) {
            return _lotService.GetLotById(id);
        }

        void IAuctionService.DeleteAuction(int id) {
            _auctionService.DeleteAuction(id);
        }

        Auction IAuctionService.GetAuctionById(int id) {
            return _auctionService.GetAuctionById(id);
        }

        List<ArtPiece> IArtPieceService.GetAllArtPieces() {
            return _artPieceService.GetAllArtPieces();
        }

        public void UpdateArtPiece(ArtPiece piece) {
            _artPieceService.UpdateArtPiece(piece);
        }

        void IArtPieceService.DeleteArtPiece(int id) {
            _artPieceService.DeleteArtPiece(id);
        }

        ArtPiece IArtPieceService.GetArtPieceById(int id) {
            return _artPieceService.GetArtPieceById(id);
        }

        public List<ArtPiece> GetAllAvilableArtPieces() {
            _artPieceService.GetAllAvilableArtPieces();
        }

        public void AddBid(Bid bid) {
            _bidService.AddBid(bid);
        }

        public List<Bid> GetAllBidsByLot(Lot lot) {
            return _bidService.GetAllBidsByLot(lot);
        }
    }
}