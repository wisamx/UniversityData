﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity]
    public interface IConsortium
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        string Id { get; }

        // TODO: Add other property references here
    }
}
