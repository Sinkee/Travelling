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
    
    public partial class PolicyInfo
    {
        public int Id { get; set; }
        public string HotelId { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
