namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdersItem")]
    public partial class OrdersItem
    {
        public int OrdersItemId { get; set; }

        public int ItemId { get; set; }

        public int OrderId { get; set; }
    }
}
