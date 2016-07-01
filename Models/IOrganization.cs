using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("foaf:Organization")]
    public interface IOrganization
    {
        [Required]
        [PropertyType("rdfs:label")]
        string Title { get; set; }

        [PropertyType("rdfs:comment")]
        string Description { get; set; }

        IPerson HeadedBy { get; set; }

        string Address { get; set; }

        string Email { get; set; }

        [PropertyType("foaf:phone")]
        string Phone { get; set; }

        string Fax { get; set; }

        [PropertyType("org:hasSubOrganization")]
        [InverseProperty("ParentOrganization")]
        ICollection<IOrganization> SubOrganizations { get; set; }

        [PropertyType("org:subOrganizationOf")]
        IOrganization ParentOrganization { get; set; }

    }
}
