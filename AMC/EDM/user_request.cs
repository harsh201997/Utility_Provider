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
    
    public partial class user_request
    {
        public int userreq_id { get; set; }
        public Nullable<int> sptype_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string req_data { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public Nullable<int> sp_id { get; set; }
        public Nullable<int> token { get; set; }
        public Nullable<System.DateTime> processdate { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
    }
}
