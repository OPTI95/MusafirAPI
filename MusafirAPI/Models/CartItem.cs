using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public int? CartId { get; set; }

    public Guid? ProductId { get; set; }

    public int Quantity { get; set; }

}
