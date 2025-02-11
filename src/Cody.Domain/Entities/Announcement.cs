﻿using Cody.Domain.Commons;
using Cody.DataAccess.Enitties.Commons;

namespace Cody.Domain.Entities;

public class Announcement : Auditable
{
    public string Name { get; set; }
    public string Content { get; set; }
    public long? MediaId { get; set; }

    public Asset Media { get; set; }
}