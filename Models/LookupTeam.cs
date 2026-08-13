using System;
using System.Collections.Generic;

namespace TyphoonTaskingTool.Models;

public partial class LookupTeam
{
    public int TeamId { get; set; }

    public string? TeamNameLong { get; set; }

    public string? TeamNameShort { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<RequestUpdate> RequestUpdates { get; set; } = new List<RequestUpdate>();
}
