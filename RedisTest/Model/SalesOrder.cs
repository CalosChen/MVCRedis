using System;

namespace RedisTest.Model
{
    public class SalesOrder
    {
        public Guid SalesOrderID { set; get; }
        public String SalesOrderNo { set; get; }
        public Guid BranchID { set; get; }
        public Guid CustomerID { set; get; }
        public String CustomerCode { set; get; }
        public String CustCompanyName { set; get; }
        public String CustAddress { set; get; }
        public DateTime? SalesOrderDate { set; get; }
        public String Staff { set; get; }
        public String Merchandiser { set; get; }

        public DateTime? ShipmentDate { set; get; }
        public String Currency { set; get; }

        public Decimal ExRate { set; get; }
        public String OnAbout { set; get; }
        public String Agent { set; get; }
        public String AgentCode { set; get; }
        public String RefSONo { set; get; }
        public Decimal TotalQTY { set; get; }
        public Decimal? TotalCBM { set; get; }
        public Decimal? ProdAmount { set; get; }
        public Decimal? AddAmount { set; get; }
        public Decimal? LessAmount { set; get; }
        public Decimal? TotalAmount { set; get; }
        public Decimal? ProdAmountUSD { set; get; }
        public Decimal? AddAmountUSD { set; get; }
        public Decimal? LessAmountUSD { set; get; }
        public Decimal? TotalAmountUSD { set; get; }
        public String PaymentTerm1 { set; get; }
        public String PaymentTerm2 { set; get; }
        public String PaymentTerm3 { set; get; }
        public String PaymentTerm4 { set; get; }
        public String LetterHeadCode { set; get; }
        public String ModeOfShipment { set; get; }
        public String ContainerSize { set; get; }
        public String DeliveryTerm1 { set; get; }
        public String DeliveryTerm2 { set; get; }
        public String PricePort { set; get; }
        public String ShipmentFrom { set; get; }
        public String ShipmentTo { set; get; }
        public String Orgin { set; get; }
        public String RevisionNo { set; get; }
        public String RevisiedDetails { set; get; }
        public String OC { set; get; }
        public String FinalTerm { set; get; }
        public String Cx { set; get; }
        public String ProductRemark { set; get; }
        public String ShipMark { set; get; }
        public String SideMark { set; get; }
        public String Remark { set; get; }
        public String Notes { set; get; }
        public Int16? IsLock { set; get; }
        public Int16? Signature { set; get; }
        public Int16 OrderStatus { set; get; }
        public Int16 ApprovalStatus { set; get; }
        public Int16 Status { set; get; }
        public Int16? OSReport { set; get; }
        public String CreatedBy { set; get; }
        public DateTime? CreatedDate { set; get; }
        public String LastModifiedBy { set; get; }
        public DateTime? LastModifiedDate { set; get; }
    }
}
