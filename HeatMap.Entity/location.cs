//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeatMap.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class location
    {
        public int cartodb_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string the_geom { get; set; }
        public string address { get; set; }
        public Nullable<bool> cartodb_georef_status { get; set; }
        public Nullable<int> workstations { get; set; }
        public Nullable<int> laptops { get; set; }
        public string contact { get; set; }
    }
}
