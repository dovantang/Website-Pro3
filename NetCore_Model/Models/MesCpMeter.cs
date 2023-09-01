using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MesCpMeter
{
    public long Id { get; set; }

    public string? Area { get; set; }

    public string? RouteId { get; set; }

    public string? LineId { get; set; }

    public string? DeviceId { get; set; }

    public string? ItemModel { get; set; }

    public string? Model { get; set; }

    public string? ParameterId { get; set; }

    public string? ParameterName { get; set; }

    public string? LotNo { get; set; }

    public string? Mpn { get; set; }

    public string? ShtBarcode { get; set; }

    public string? PcsBarcode { get; set; }

    public double? Lsl { get; set; }

    public double? Usl { get; set; }

    public string? Value { get; set; }

    public DateTime? EnterTime { get; set; }

    public string? UserId { get; set; }

    public string? Unit { get; set; }

    public int? State { get; set; }

    public double? UslAlarm { get; set; }

    public double? LslAlarm { get; set; }
}
