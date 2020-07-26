using DAL.Entity.Base;
using System;
using System.Collections.Generic;

namespace DAL.Entity
{
    public class Order:CoreEntity
    {
        public Order()
        {
            this.Confirmed = false;

            //Sipariş oluştur dediğimizde yeni bir liste oluşturup duracak. Onay alındığında sepetteki ürünlerin bilgisini alacak.
            OrderDetails = new List<OrderDetail>();
        }
        public Guid AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public bool Confirmed { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}