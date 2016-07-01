using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("unio:University")]
    public interface IUniversity
    {
        [Identifier("unidata:University/")]
        string Id { get; }

        [Required]
        [PropertyType("rdfs:label")]
        string Title { get; set; }

        [PropertyType("rdfs:comment")]
        string Description { get; set; }

        [InverseProperty("University")]
        ICollection<ICollege> Colleges { get; set; }

    }
}
