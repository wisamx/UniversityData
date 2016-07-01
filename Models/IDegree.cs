using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("unio:Degree")]
    public interface IDegree
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        string Id { get; }

        // TODO: Add other property references here
    }
}
