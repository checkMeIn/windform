//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Check_Me_In
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole
    {
        public int id { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> roleID { get; set; }
    
        public virtual role role { get; set; }
        public virtual User User { get; set; }
    }
}