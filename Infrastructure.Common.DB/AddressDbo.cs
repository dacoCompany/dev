//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Common.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddressDbo : IEntity
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public Nullable<bool> IsDeliveryAddress { get; set; }
        public Nullable<bool> IsBillingAddress { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public int UserAccountId { get; set; }
        public int LocationId { get; set; }
    
        public virtual LocationDbo Location { get; set; }
        public virtual UserAccountDbo UserAccount { get; set; }
    }
}