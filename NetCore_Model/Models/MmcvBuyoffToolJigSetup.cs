using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MmcvBuyoffToolJigSetup
{
    public long Id { get; set; }

    public string? ProcessId { get; set; }

    public string? Model { get; set; }

    public string? ProcessName { get; set; }

    public int? QtyOfTool { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
