﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFUnitTest.LotServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lot", Namespace="http://schemas.datacontract.org/2004/07/WCFBusinessLogic.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Lot : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.ArtPiece ArtPieceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.Auction AuctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AuctionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.Bid[] BidsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LotIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinBidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PositionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.ArtPiece ArtPiece {
            get {
                return this.ArtPieceField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtPieceField, value) != true)) {
                    this.ArtPieceField = value;
                    this.RaisePropertyChanged("ArtPiece");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.Auction Auction {
            get {
                return this.AuctionField;
            }
            set {
                if ((object.ReferenceEquals(this.AuctionField, value) != true)) {
                    this.AuctionField = value;
                    this.RaisePropertyChanged("Auction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AuctionId {
            get {
                return this.AuctionIdField;
            }
            set {
                if ((this.AuctionIdField.Equals(value) != true)) {
                    this.AuctionIdField = value;
                    this.RaisePropertyChanged("AuctionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.Bid[] Bids {
            get {
                return this.BidsField;
            }
            set {
                if ((object.ReferenceEquals(this.BidsField, value) != true)) {
                    this.BidsField = value;
                    this.RaisePropertyChanged("Bids");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LotId {
            get {
                return this.LotIdField;
            }
            set {
                if ((this.LotIdField.Equals(value) != true)) {
                    this.LotIdField = value;
                    this.RaisePropertyChanged("LotId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MinBid {
            get {
                return this.MinBidField;
            }
            set {
                if ((this.MinBidField.Equals(value) != true)) {
                    this.MinBidField = value;
                    this.RaisePropertyChanged("MinBid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Position {
            get {
                return this.PositionField;
            }
            set {
                if ((this.PositionField.Equals(value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ArtPiece", Namespace="http://schemas.datacontract.org/2004/07/WCFBusinessLogic.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class ArtPiece : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ArtPieceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtistField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PurchasePriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ArtPieceId {
            get {
                return this.ArtPieceIdField;
            }
            set {
                if ((this.ArtPieceIdField.Equals(value) != true)) {
                    this.ArtPieceIdField = value;
                    this.RaisePropertyChanged("ArtPieceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Artist {
            get {
                return this.ArtistField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtistField, value) != true)) {
                    this.ArtistField = value;
                    this.RaisePropertyChanged("Artist");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PictureUrl {
            get {
                return this.PictureUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureUrlField, value) != true)) {
                    this.PictureUrlField = value;
                    this.RaisePropertyChanged("PictureUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PurchasePrice {
            get {
                return this.PurchasePriceField;
            }
            set {
                if ((this.PurchasePriceField.Equals(value) != true)) {
                    this.PurchasePriceField = value;
                    this.RaisePropertyChanged("PurchasePrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auction", Namespace="http://schemas.datacontract.org/2004/07/WCFBusinessLogic.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Auction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AuctionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuctionNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan LotDurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.Lot[] LotsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MultiplierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.Status StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AuctionId {
            get {
                return this.AuctionIdField;
            }
            set {
                if ((this.AuctionIdField.Equals(value) != true)) {
                    this.AuctionIdField = value;
                    this.RaisePropertyChanged("AuctionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuctionName {
            get {
                return this.AuctionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AuctionNameField, value) != true)) {
                    this.AuctionNameField = value;
                    this.RaisePropertyChanged("AuctionName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan LotDuration {
            get {
                return this.LotDurationField;
            }
            set {
                if ((this.LotDurationField.Equals(value) != true)) {
                    this.LotDurationField = value;
                    this.RaisePropertyChanged("LotDuration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.Lot[] Lots {
            get {
                return this.LotsField;
            }
            set {
                if ((object.ReferenceEquals(this.LotsField, value) != true)) {
                    this.LotsField = value;
                    this.RaisePropertyChanged("Lots");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Multiplier {
            get {
                return this.MultiplierField;
            }
            set {
                if ((this.MultiplierField.Equals(value) != true)) {
                    this.MultiplierField = value;
                    this.RaisePropertyChanged("Multiplier");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.Status Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bid", Namespace="http://schemas.datacontract.org/2004/07/WCFBusinessLogic.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Bid : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BidIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.Member BidderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFUnitTest.LotServiceReference.Lot LotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LotIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BidId {
            get {
                return this.BidIdField;
            }
            set {
                if ((this.BidIdField.Equals(value) != true)) {
                    this.BidIdField = value;
                    this.RaisePropertyChanged("BidId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.Member Bidder {
            get {
                return this.BidderField;
            }
            set {
                if ((object.ReferenceEquals(this.BidderField, value) != true)) {
                    this.BidderField = value;
                    this.RaisePropertyChanged("Bidder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFUnitTest.LotServiceReference.Lot Lot {
            get {
                return this.LotField;
            }
            set {
                if ((object.ReferenceEquals(this.LotField, value) != true)) {
                    this.LotField = value;
                    this.RaisePropertyChanged("Lot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LotId {
            get {
                return this.LotIdField;
            }
            set {
                if ((this.LotIdField.Equals(value) != true)) {
                    this.LotIdField = value;
                    this.RaisePropertyChanged("LotId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/WCFBusinessLogic.Model")]
    public enum Status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ready = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ongoing = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Complete = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Member", Namespace="http://schemas.datacontract.org/2004/07/WCFBusinessLogic.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Member : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CprField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MemberIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PointsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cpr {
            get {
                return this.CprField;
            }
            set {
                if ((object.ReferenceEquals(this.CprField, value) != true)) {
                    this.CprField = value;
                    this.RaisePropertyChanged("Cpr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MemberId {
            get {
                return this.MemberIdField;
            }
            set {
                if ((this.MemberIdField.Equals(value) != true)) {
                    this.MemberIdField = value;
                    this.RaisePropertyChanged("MemberId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Points {
            get {
                return this.PointsField;
            }
            set {
                if ((this.PointsField.Equals(value) != true)) {
                    this.PointsField = value;
                    this.RaisePropertyChanged("Points");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LotServiceReference.ILotService")]
    public interface ILotService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/Add", ReplyAction="http://tempuri.org/ILotService/AddResponse")]
        void Add(WCFUnitTest.LotServiceReference.Lot lot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/Add", ReplyAction="http://tempuri.org/ILotService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(WCFUnitTest.LotServiceReference.Lot lot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/GetAllByAuction", ReplyAction="http://tempuri.org/ILotService/GetAllByAuctionResponse")]
        WCFUnitTest.LotServiceReference.Lot[] GetAllByAuction(WCFUnitTest.LotServiceReference.Auction auction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/GetAllByAuction", ReplyAction="http://tempuri.org/ILotService/GetAllByAuctionResponse")]
        System.Threading.Tasks.Task<WCFUnitTest.LotServiceReference.Lot[]> GetAllByAuctionAsync(WCFUnitTest.LotServiceReference.Auction auction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/Update", ReplyAction="http://tempuri.org/ILotService/UpdateResponse")]
        void Update(WCFUnitTest.LotServiceReference.Lot lot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/Update", ReplyAction="http://tempuri.org/ILotService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(WCFUnitTest.LotServiceReference.Lot lot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/Delete", ReplyAction="http://tempuri.org/ILotService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/Delete", ReplyAction="http://tempuri.org/ILotService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/GetById", ReplyAction="http://tempuri.org/ILotService/GetByIdResponse")]
        WCFUnitTest.LotServiceReference.Lot GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotService/GetById", ReplyAction="http://tempuri.org/ILotService/GetByIdResponse")]
        System.Threading.Tasks.Task<WCFUnitTest.LotServiceReference.Lot> GetByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILotServiceChannel : WCFUnitTest.LotServiceReference.ILotService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LotServiceClient : System.ServiceModel.ClientBase<WCFUnitTest.LotServiceReference.ILotService>, WCFUnitTest.LotServiceReference.ILotService {
        
        public LotServiceClient() {
        }
        
        public LotServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LotServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LotServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LotServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(WCFUnitTest.LotServiceReference.Lot lot) {
            base.Channel.Add(lot);
        }
        
        public System.Threading.Tasks.Task AddAsync(WCFUnitTest.LotServiceReference.Lot lot) {
            return base.Channel.AddAsync(lot);
        }
        
        public WCFUnitTest.LotServiceReference.Lot[] GetAllByAuction(WCFUnitTest.LotServiceReference.Auction auction) {
            return base.Channel.GetAllByAuction(auction);
        }
        
        public System.Threading.Tasks.Task<WCFUnitTest.LotServiceReference.Lot[]> GetAllByAuctionAsync(WCFUnitTest.LotServiceReference.Auction auction) {
            return base.Channel.GetAllByAuctionAsync(auction);
        }
        
        public void Update(WCFUnitTest.LotServiceReference.Lot lot) {
            base.Channel.Update(lot);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(WCFUnitTest.LotServiceReference.Lot lot) {
            return base.Channel.UpdateAsync(lot);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public WCFUnitTest.LotServiceReference.Lot GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<WCFUnitTest.LotServiceReference.Lot> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
    }
}