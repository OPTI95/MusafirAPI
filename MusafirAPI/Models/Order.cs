using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public Guid? UserId { get; set; }

    public int? CartId { get; set; }

    public DateTime? OrderDate { get; set; }

    public bool? IsCompleted { get; set; }

}
