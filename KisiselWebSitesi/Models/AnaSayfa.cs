using System;
using System.Collections.Generic;

namespace KisiselWebSitesi.Models;

public partial class AnaSayfa
{
    public int Id { get; set; }

    public string Profil { get; set; } = null!;

    public string Unvan { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Iletisim { get; set; } = null!;

    public string? Isim { get; set; }
}
