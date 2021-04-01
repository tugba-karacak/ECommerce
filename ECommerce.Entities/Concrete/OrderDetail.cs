using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class OrderDetail:IEntity
    {
        

        public int? ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
