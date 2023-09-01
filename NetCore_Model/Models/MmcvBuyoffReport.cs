using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MmcvBuyoffReport
{
    public long Id { get; set; }

    public int? Area { get; set; }

    public string? Line { get; set; }

    public string? ReportId { get; set; }

    public string? Lot { get; set; }

    public string? Model { get; set; }

    public string? Mpn { get; set; }

    public string? OperatorId { get; set; }

    public string? Result { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public int? Active { get; set; }

    public int? IsSubmit { get; set; }

    public string? SubmitBy { get; set; }

    public DateTime? SubmitDate { get; set; }
}
