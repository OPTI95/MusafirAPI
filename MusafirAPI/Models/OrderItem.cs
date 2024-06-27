using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int? OrderId { get; set; }

    public Guid? ProductId { get; set; }

    public int Quantity { get; set; }

}
