using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class Mmcvuser
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? GroupIds { get; set; }

    public DateTime? DateCreate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public string? PhoneNumber { get; set; }
}
