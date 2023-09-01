using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MmcvuserGroup
{
    public int GroupId { get; set; }

    public int? ParentId { get; set; }

    public string? GroupName { get; set; }

    public string? ProgramId { get; set; }

    public string? Descriptions { get; set; }

    public DateTime? DateCreate { get; set; }

    public DateTime? DateUpdate { get; set; }
}
