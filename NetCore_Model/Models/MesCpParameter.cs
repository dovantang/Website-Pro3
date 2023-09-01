using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MesCpParameter
{
    public long Id { get; set; }

    public string? RouteId { get; set; }

    public string? LineId { get; set; }

    public string? ItemModel { get; set; }

    public string? Model { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterId { get; set; }

    public string? DeviceId { get; set; }

    public string? FrequencyCollection { get; set; }

    public string? DataCollection { get; set; }

    public double? Lsl { get; set; }

    public double? Usl { get; set; }

    public string? Unit { get; set; }

    public bool? EBuyoff { get; set; }

    public bool? ParameterMonitoring { get; set; }

    public bool? State { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public double? UslAlarm { get; set; }

    public double? LslAlarm { get; set; }
}
