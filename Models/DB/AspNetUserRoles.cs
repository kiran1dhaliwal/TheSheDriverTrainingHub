﻿using System;
using System.Collections.Generic;

namespace TheFinalSheDriverTrainingHub.Models.DB
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
