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

        public async Task<IResult> Add(EmployeeInfoDto employeeInfoDto)
        {
            var emp = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.Add(emp);
            return new SuccessResult(Messages.EmployeeInfoAdded);
        }

        public async Task<IResult> EmployeeInfoAdded(EmployeeInfoDto employeeInfoDto)
        {
            var emp = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.Add(emp);
            return new SuccessResult(Messages.EmployeeInfoAdded);
        }

        public async Task<IResult> EmployeeInfoDeleted(EmployeeInfoDto employeeInfoDto)
        {
            var empDel = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.Delete(empDel);
            return new SuccessResult(Messages.EmployeeInfoDelete);
        }

        public async Task<IResult> EmployeeInfoUpdate(EmployeeInfoDto employeeInfoDto)
        {
            var empUpdate = _mapper.Map<EmployeeInfo>(employeeInfoDto);
            await _employeeInfo.Update(empUpdate);
            return new SuccessResult(Messages.EmployeeInfoUpdate);
        }

        public async Task<IDataResult<List<EmployeeInfoDto>>> GetAll()
        {
            var resultEI = await _employeeInfo.GetAll();
            var resultDto = _mapper.Map<List<EmployeeInfoDto>>(resultEI);
            return new SuccessDateResult<List<EmployeeInfoDto>>(resultDto, Messages.EmlpoyeesList);
        }

        public async Task<IDataResult<EmployeeInfoDto>> GetById(int id)
        {
            var emp = await _employeeInfo.Get(e => e.EmployeeID == id);
            var empDto = _mapper.Map<EmployeeInfoDto>(emp);
            return new SuccessDateResult<EmployeeInfoDto>(empDto, Messages.EmlpoyeesList);
        }

        public async Task<IDataResult<List<EmployeeInfoDto>>> SearchBloodTypeID(int bloodID)
        {
            var emp = await _employeeInfo.GetAll(b => b.BloodID == bloodID);
            var empDto = _mapper.Map<List<EmployeeInfoDto>>(emp);
            return new SuccessDateResult<List<EmployeeInfoDto>>(empDto, Messages.EmlpoyeesList);
        }
    }
}
