//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMC.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_plan
    {
        public int plan_id { get; set; }
        public Nullable<int> sp_id { get; set; }
        public string plan_name { get; set; }
        public string plan_description { get; set; }
        public Nullable<decimal> installment { get; set; }
        public Nullable<int> no_of_services { get; set; }
        public string plan_benifits { get; set; }
        public string plan_status { get; set; }
        public Nullable<decimal> charges { get; set; }
        public string plan_duration { get; set; }
    }
}
