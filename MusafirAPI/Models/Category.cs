using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class Category
{
    public Guid CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

}
