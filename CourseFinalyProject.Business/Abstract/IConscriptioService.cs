using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs;
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
        Task<IResult> Added(ConscriptionDto conscriptionDto);
        Task<IResult> Deleted(ConscriptionDto conscriptionDto);
        Task<IResult> Updated(ConscriptionDto conscriptionDto);
        Task<IDataResult<List<ConscriptionDto>>> GetAll();
        Task<IDataResult<List<ConscriptionDto>>> GetByID(int employeeID);
        Task<IDataResult<List<ConscriptionDepartamentDetailsDto>>> GetDepartamentID(int departamentId);
    }    
}
