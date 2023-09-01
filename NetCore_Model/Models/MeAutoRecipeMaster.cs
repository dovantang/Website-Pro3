using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MeAutoRecipeMaster
{
    public int Id { get; set; }

    public string? ParameterName { get; set; }

    public string? Value { get; set; }

    public string? ProgramName { get; set; }

    public string? MachineModel { get; set; }

    public string? ProductModel { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
