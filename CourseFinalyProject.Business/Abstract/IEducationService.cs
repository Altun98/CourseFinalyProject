using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IEducationService
    {
        Task<IResult> EducationAdd(EducationDto educationDto);
        Task<IDataResult<List<EducationDto>>> GetAll();
        Task<IResult> EducationDeleted(EducationDto educationDto);
        Task<IResult> EducationUpdate(EducationDto educationDto);

    }
}
