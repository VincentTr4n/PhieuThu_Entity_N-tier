//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS_Objects
{
    using System;
    
    public partial class ShowAccountTrans_Result
    {
        public int TranID { get; set; }
        public System.DateTime TranDate { get; set; }
        public string TranType { get; set; }
        public string TranTypeName { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string RefNo { get; set; }
        public System.DateTime RefDate { get; set; }
        public string Des_StationID { get; set; }
        public string Dep_StationID { get; set; }
        public string Descr { get; set; }
        public Nullable<int> CostVol { get; set; }
        public Nullable<int> ActVol { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string DAcc { get; set; }
        public string CAcc { get; set; }
        public decimal OrigAmt { get; set; }
        public string SlsPerID { get; set; }
        public string D_CustID { get; set; }
        public string CustName { get; set; }
        public string C_CustID { get; set; }
        public int Released { get; set; }
        public int Completed { get; set; }
    }
}
