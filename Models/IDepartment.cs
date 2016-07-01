using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("aiiso:Department")]
    public interface IDepartment : IAcademicOrganization
    {
        [Identifier("unidata:Department/")]
        string Id { get; }

        ICollege College { get; set; }

    }
}
