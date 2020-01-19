//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservations
    {
        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public int CostumerID { get; set; }
        public byte ReservStatsID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string CouponCode { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Coupons Coupons { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual ReservationStatuses ReservationStatuses { get; set; }
    }
}
