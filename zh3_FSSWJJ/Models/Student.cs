using System;
using System.Collections.Generic;

namespace zh3_FSSWJJ.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Neptun { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
