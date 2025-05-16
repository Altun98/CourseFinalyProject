using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class EmployeeInfoManager : IEmployeeInfoService
    {
        private readonly IEmployeeInfoDal _employeeInfo;
        private readonly IMapper _mapper;
        public EmployeeInfoManager(IEmployeeInfoDal employeeInfo, IMapper mapper)
        {
            _employeeInfo = employeeInfo;
            _mapper = mapper;
        }

        public async Task<IResult> Add(ResultEmployeeInfoDto employeeInfoDto)
        {
            var emp = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.AddAsync(emp);
            return new SuccessResult(Messages.EmployeeInfoAdded);
        }

        public async Task<IResult> EmployeeInfoAddedAsync(ResultEmployeeInfoDto employeeInfoDto)
        {
            var emp = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.AddAsync(emp);
            return new SuccessResult(Messages.EmployeeInfoAdded);
        }

        public async Task<IResult> EmployeeInfoDeletedAsync(ResultEmployeeInfoDto employeeInfoDto)
        {
            var empDel = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.DeleteAsync(empDel);
            return new SuccessResult(Messages.EmployeeInfoDelete);
        }

        public async Task<IResult> EmployeeInfoUpdateAsync(ResultEmployeeInfoDto employeeInfoDto)
        {
            var empUpdate = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.UpdateAsync(empUpdate);
            return new SuccessResult(Messages.EmployeeInfoUpdate);
        }

        public async Task<IDataResult<List<ResultEmployeeInfoDto>>> GetAllAsync()
        {
            var resultEI = await _employeeInfo.GetAllAsync();
            var resultDto = _mapper.Map<List<ResultEmployeeInfoDto>>(resultEI);
            return new SuccessDateResult<List<ResultEmployeeInfoDto>>(resultDto, Messages.EmlpoyeesList);
        }

        public async Task<IDataResult<ResultEmployeeInfoDto>> GetById(int id)
        {
            var emp = await _employeeInfo.GetAsync(e => e.EmployeeID == id);
            var empDto = _mapper.Map<ResultEmployeeInfoDto>(emp);
            return new SuccessDateResult<ResultEmployeeInfoDto>(empDto, Messages.EmlpoyeesList);
        }

        public async Task<IDataResult<List<ResultEmployeeInfoDto>>> GetSearchBloodTypeIdAsync(int bloodID)
        {
            var emp = await _employeeInfo.GetAllAsync(b => b.BloodID == bloodID);
            var empDto = _mapper.Map<List<ResultEmployeeInfoDto>>(emp);
            return new SuccessDateResult<List<ResultEmployeeInfoDto>>(empDto, Messages.EmlpoyeesList);
        }
    }
}
