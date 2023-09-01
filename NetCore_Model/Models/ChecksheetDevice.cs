using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class ChecksheetDevice
{
    public int SerialId { get; set; }

    public string DeviceId { get; set; } = null!;

    public string? MasterName { get; set; }

    public string? Line { get; set; }

    public string? Model { get; set; }

    public string? UserUpdate { get; set; }

    public DateTime? EnterTime { get; set; }
}
