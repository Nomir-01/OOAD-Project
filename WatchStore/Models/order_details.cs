//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int orderDetail_Id { get; set; }
        public int fk_orderId { get; set; }
        public int fk_productId { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
    
        public virtual orders orders { get; set; }
        public virtual products products { get; set; }
    }
}
