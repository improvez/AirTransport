using System;
using System.Collections.Generic;

namespace AirTransport.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Aircraft> Aircraft { get; set; } = new List<Aircraft>();
}
