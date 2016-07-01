using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("aiiso:College")]
    public interface ICollege
    {
        [Identifier("unidata:College/")]
        string Id { get; }

        [Required]
        [PropertyType("rdfs:label")]
        string Title { get; set; }

        [PropertyType("rdfs:comment")]
        string Description { get; set; }

        IUniversity University { get; set; }

        [InverseProperty("College")]
        ICollection<IDepartment> IDepartments { get; set; }

    }
}
        