﻿using Cody.Domain.Commons;

namespace Cody.Domain.Entities.Permissions;

public class Role : Auditable
{
    public string Name { get; set; }
}
