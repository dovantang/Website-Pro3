using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MmcvBuyoffQualitySpecCriterion
{
    public long Id { get; set; }

    public string? ProcessId { get; set; }

    public string? SpecName { get; set; }

    public string? SpecNameEn { get; set; }

    public string? Image { get; set; }
}
