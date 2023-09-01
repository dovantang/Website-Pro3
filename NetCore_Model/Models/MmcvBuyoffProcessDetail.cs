using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MmcvBuyoffProcessDetail
{
    public long Id { get; set; }

    public string? ReportId { get; set; }

    public string? ProcessId { get; set; }

    public string? MachineId { get; set; }

    public string? Category { get; set; }

    public string? Result { get; set; }
}
