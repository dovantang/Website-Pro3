using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MesMappingParameterHeaderName
{
    public int Id { get; set; }

    public int? RouteId { get; set; }

    public string? ParameterName { get; set; }

    public string? HeaderName { get; set; }

    public string? Marking { get; set; }
}
