using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MesCpParameterMonitoring
{
    public int Id { get; set; }

    public DateTime? EnterDate { get; set; }

    public int? TimeZone { get; set; }

    public string? RouteId { get; set; }

    public bool? IsDelete { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Status { get; set; }

    public int? Type { get; set; }

    public string? LineId { get; set; }
}
