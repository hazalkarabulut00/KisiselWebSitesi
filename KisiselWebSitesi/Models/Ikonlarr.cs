using System;
using System.Collections.Generic;

namespace KisiselWebSitesi.Models;

public partial class Ikonlarr
{
    public int Id { get; set; }

    public string Ikon { get; set; } = null!;

    public string Link { get; set; } = null!;
}
