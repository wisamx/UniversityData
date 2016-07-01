using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using BrightstarDB.EntityFramework;

namespace UniversityData.Models
{
    [Entity("unio:AcademicOrganization")]
    public interface IAcademicOrganization : IOrganization
    {

        [PropertyType("unio:offersDegree")]
        ICollection<IDegree> offerseDegree { get; set; }

    }
}
