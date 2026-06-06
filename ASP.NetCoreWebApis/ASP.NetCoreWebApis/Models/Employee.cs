using System;
using System.Collections.Generic;

namespace ASP.NetCoreWebApis.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Married { get; set; }

    public int Salary { get; set; }

    public string? Department { get; set; }

    public string? Descrption { get; set; }
}
