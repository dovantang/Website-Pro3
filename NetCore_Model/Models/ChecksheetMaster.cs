using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class ChecksheetMaster
{
    public int MasterId { get; set; }

    public string? MasterName { get; set; }

    public int? MasterIndex { get; set; }

    public string? TestContents { get; set; }

    public string? Criteria { get; set; }

    public string? Method { get; set; }

    public string? Frequency { get; set; }

    public string? StyleValue { get; set; }

    public int? MasterStatus { get; set; }

    public DateTime? EnterTime { get; set; }

    public string? UserUpdate { get; set; }
}
