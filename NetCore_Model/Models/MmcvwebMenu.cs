using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MmcvwebMenu
{
    public int MenuId { get; set; }

    public int? ParentId { get; set; }

    public string? MenuName { get; set; }

    public bool? IsPublic { get; set; }

    public string? IconClass { get; set; }

    public string? Descriptions { get; set; }

    public string? UrlLink { get; set; }

    public int? MenuOrder { get; set; }

    public bool? IsVisible { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? IsSecondChild { get; set; }
}
