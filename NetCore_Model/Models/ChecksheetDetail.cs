using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class ChecksheetDetail
{
    public long SerialId { get; set; }

    public string? MasterName { get; set; }

    public int? MasterIndex { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Day { get; set; }

    public int? Shifts { get; set; }

    public string? DeviceId { get; set; }

    public string? Result { get; set; }

    public string? Check { get; set; }

    public string? Confirm { get; set; }

    public string? UserUpdate { get; set; }

    public DateTime? EnterTime { get; set; }
}
