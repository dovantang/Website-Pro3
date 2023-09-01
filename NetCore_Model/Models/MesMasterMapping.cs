using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MesMasterMapping
{
    public int Id { get; set; }

    public string? Area { get; set; }

    public string? RouteId { get; set; }

    public string? ProcessName { get; set; }

    public string? LineId { get; set; }

    public string? DeviceId { get; set; }

    public string? NokId { get; set; }

    public string? DeviceName { get; set; }

    public string? ItemModel { get; set; }

    public string? Model { get; set; }

    public string? Vendor { get; set; }

    public DateTime? EnterTime { get; set; }

    public int? Order { get; set; }
}
