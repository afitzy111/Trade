//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Option
    {
        public int ID { get; set; }
        public Nullable<int> Instrument_ID { get; set; }
        public Nullable<int> Underlying_Instrument { get; set; }
        public Nullable<decimal> Strike { get; set; }
    
        public virtual instrument instrument { get; set; }
        public virtual instrument instrument1 { get; set; }
    }
}