using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.CombatOperationsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface ICombatOperationsService
    {
        Task<IDataResult<List<ResultCombatOperationsDto>>> GetAllAsync();
        Task<IResult> AddedAsync(ResultCombatOperationsDto combatOperationsDto);
        Task<IResult> DeleteAsync(ResultCombatOperationsDto combatOperationsDto);
        Task<IResult> UpdateAsync(ResultCombatOperationsDto combatOperationsDto);
        Task<IDataResult<List<ResultCombatOperationsDto>>> GetEmployeeCombatOperationAsync(int employeeId);
    }
}
