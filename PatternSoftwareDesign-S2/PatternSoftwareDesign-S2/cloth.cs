//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatternSoftwareDesign_S2
{
    using System;
    using System.Collections.Generic;
    
    public partial class cloth
    {
        public string cloth_id { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public string clothes_type_id { get; set; }
    
        public virtual clothes_type clothes_type { get; set; }
    }
}
