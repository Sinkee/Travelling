//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HACHATMapping
    {
        public int Id { get; set; }
        public Nullable<int> HACID { get; set; }
        public Nullable<int> HATID { get; set; }
        public string HotelID { get; set; }
        public Nullable<System.DateTime> LastModifyTine { get; set; }
        public string DescriptionText { get; set; }
    
        public virtual HAC HAC { get; set; }
        public virtual HAT HAT { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
