using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class Feedback
{
    public Guid FeedbackId { get; set; }

    public string? Text { get; set; }

    public int? Rating { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? UserId { get; set; }

}
