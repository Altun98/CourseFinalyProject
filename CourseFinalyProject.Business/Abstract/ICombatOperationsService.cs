using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface ICombatOperationsService
    {
        Task<IDataResult<List<CombatOperationsDto>>> GetAll();
        Task<IResult> Added(CombatOperationsDto combatOperationsDto);
        Task<IResult> Delete(CombatOperationsDto combatOperationsDto);
        Task<IResult> Update(CombatOperationsDto combatOperationsDto);
        Task<IDataResult<List<CombatOperationsDto>>> GetEmployeeCombatOperation(int employeeId);
    }
}
