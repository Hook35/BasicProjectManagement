//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProcess
    {
        public int UserProcessID { get; set; }
        public Nullable<int> UsersID { get; set; }
        public Nullable<int> ProcessID { get; set; }
        public Nullable<int> UserRolesID { get; set; }
    
        public virtual Process Process { get; set; }
        public virtual UserRoles UserRoles { get; set; }
        public virtual Users Users { get; set; }
    }
}
