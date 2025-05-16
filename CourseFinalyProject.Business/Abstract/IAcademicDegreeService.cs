using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.AcademicDegreeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IAcademicDegreeService
    {
        Task<IResult> AddedAsync(CreateAcademicDegreeDto createAcademicDegreeDto);
        Task<IResult> UpdateAsync(UpdateAcademicDegreeDto updateAcademicDegreeDto);
        Task<IResult> DeleteAsync(ResultAcademicDegreeDto resultAcademicDegreeDto);
        Task<IDataResult<List<ResultAcademicDegreeDto>>> GetAllAsync();
        Task<IDataResult<ResultAcademicDegreeDto>> GetByIdAsync(int id);
        Task<IDataResult<ResultAcademicDegreeDto>> GetByDiplomaNumberAsync(string number);
        Task<IDataResult<List<ResultAcademicDegreeDto>>> GetDiplomaDataTimeSearchAsync(DateTime startDate, DateTime endDate);
    }
}
