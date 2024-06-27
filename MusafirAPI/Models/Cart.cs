using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public Guid? UserId { get; set; }

    public DateOnly? DateAdded { get; set; }

}
