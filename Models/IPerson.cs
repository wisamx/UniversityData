using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("foaf:Person")]
    public interface IPerson
    {

        [PropertyType("foaf:firstName")]
        string FirstName { get; set; }

        [PropertyType("foaf:lastName")]
        string LastName { get; set; }

        [PropertyType("rdfs:label")]
        string Label { get; set; }

        string Address { get; set; }

        [PropertyType("foaf:image")]
        string Image { get; set; }

        [PropertyType("foaf:phone")]
        string Phone { get; set; }

        string PrimaryEmail { get; set; }

    }
}
