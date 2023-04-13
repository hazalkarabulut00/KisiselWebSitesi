using System;
using System.Collections.Generic;

namespace KisiselWebSitesi.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string KullaniciAdi { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
