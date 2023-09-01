using System;
using System.Collections.Generic;

namespace NetCore_Model.Models;

public partial class MeAutoRecipeHistory
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? ParameterId { get; set; }

    public string? ParameterChange { get; set; }

    public string? ValueChange { get; set; }

    public string? ProgramChange { get; set; }

    public string? MachineChange { get; set; }

    public string? ProductChange { get; set; }

    public string? CreateChange { get; set; }

    public int? IsStatus { get; set; }

    public string? Acceptance { get; set; }
}
