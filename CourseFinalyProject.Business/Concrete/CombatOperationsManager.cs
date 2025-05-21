using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.CombatOperationsDtos;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class CombatOperationsManager : ICombatOperationsService
    {
        private readonly ICombatOperationsDal _combatOperations;
        private readonly IMapper _mapper;
        public CombatOperationsManager(ICombatOperationsDal combatOperations, IMapper mapper)
        {
            _combatOperations = combatOperations;
            _mapper = mapper;
        }

        public async Task<IResult> AddedAsync(CreateCombatOperationsDto combatOperationsDto)
        {
            var comOp = _mapper.Map<CombatOperations>(combatOperationsDto);
            await _combatOperations.AddAsync(comOp);
            return new SuccessResult("Elave edildi");
        }

        public async Task<IResult> DeleteAsync(ResultCombatOperationsDto combatOperationsDto)
        {
            var combat = _mapper.Map<CombatOperations>(combatOperationsDto);
            await _combatOperations.DeleteAsync(combat);
            return new SuccessResult(Messages.CombatOperationsDeleted);
        }

        public async Task<IDataResult<List<ResultCombatOperationsDto>>> GetAllAsync()
        {
            var combats = await _combatOperations.GetAllAsync();
            var result = _mapper.Map<List<ResultCombatOperationsDto>>(combats);
            return new SuccessDateResult<List<ResultCombatOperationsDto>>(result);
        }

        public async Task<IDataResult<List<ResultCombatOperationsDto>>> GetEmployeeCombatOperationAsync(int employeeId)
        {
            var combats = await _combatOperations.GetAllAsync(x => x.EmployeeID == employeeId);
            var result = _mapper.Map<List<ResultCombatOperationsDto>>(combats);
            return new SuccessDateResult<List<ResultCombatOperationsDto>>(result);
        }

        public async Task<IResult> UpdateAsync(UpdateCombatOperationsDto combatOperationsDto)
        {
            var value = _mapper.Map<CombatOperations>(combatOperationsDto);
            await _combatOperations.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
