using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
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

        public async Task<IResult> Added(CombatOperationsDto combatOperationsDto)
        {
            var comOp = _mapper.Map<CombatOperations>(combatOperationsDto);
            await _combatOperations.Add(comOp);
            return new SuccessResult("Elave edildi");
        }

        public async Task<IResult> Delete(CombatOperationsDto combatOperationsDto)
        {
            var combat = _mapper.Map<CombatOperations>(combatOperationsDto);
            await _combatOperations.Delete(combat);
            return new SuccessResult(Messages.CombatOperationsDeleted);
        }

        public async Task<IDataResult<List<CombatOperationsDto>>> GetAll()
        {
            var combats = await _combatOperations.GetAll();
            var result = _mapper.Map<List<CombatOperationsDto>>(combats);
            return new SuccessDateResult<List<CombatOperationsDto>>(result);
        }

        public async Task<IDataResult<List<CombatOperationsDto>>> GetEmployeeCombatOperation(int employeeId)
        {
            var combats = await _combatOperations.GetAll(x => x.EmployeeID == employeeId);
            var result = _mapper.Map<List<CombatOperationsDto>>(combats);
            return new SuccessDateResult<List<CombatOperationsDto>>(result);
        }

        public Task<IResult> Update(CombatOperationsDto combatOperationsDto)
        {
            throw new NotImplementedException();
        }
    }
}
