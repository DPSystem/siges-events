using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EmailsCredenciale
{
    public int Id { get; set; }

    public string? MailAdress { get; set; }

    public string? FromPassword { get; set; }

    public string? DisplayName { get; set; }

    public int? Estado { get; set; }

    public int? SectorId { get; set; }

    public string? BodyText { get; set; }
}
