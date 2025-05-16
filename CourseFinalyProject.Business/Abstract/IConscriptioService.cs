using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.ConscriptionDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IConscriptioService
    {
        // herbi caqris
        Task<IResult> AddedAsync(ResultConscriptionDto conscriptionDto);
        Task<IResult> DeletedAsync(ResultConscriptionDto conscriptionDto);
        Task<IResult> UpdatedAsync(ResultConscriptionDto conscriptionDto);
        Task<IDataResult<List<ResultConscriptionDto>>> GetAllAsync();
        Task<IDataResult<List<ResultConscriptionDto>>> GetByIDAsync(int employeeID);
        Task<IDataResult<List<ConscriptionDepartamentDetailsDto>>> GetDepartamentIdAsync(int departamentId);
    }    
}
