using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using CourseFinalyProject.Entities.DTOs.MilitaryRankDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MilitaryRankManager : IMilitaryRankService
    {

        private IMilitaryRankDal _rankDal;
        private IMapper _mapper;
        public MilitaryRankManager(IMilitaryRankDal rankDal, IMapper mapper)
        {
            _rankDal = rankDal;
            _mapper = mapper;
        }

        public async Task<IDataResult<List<ResultMilitaryRankDto>>> GetAllAsync()
        {
            var ranks = await _rankDal.GetAllAsync();
            var result = _mapper.Map<List<ResultMilitaryRankDto>>(ranks);
            return new SuccessDateResult<List<ResultMilitaryRankDto>>( result);
        }

        public async Task<IDataResult<List<ResultMilitaryRankDto>>> GetEmployeeRanksInfoAsync(int empID)
        {
            var ranks = await _rankDal.GetAllAsync(p => p.EmployeeID == empID);
            var result = _mapper.Map<List<ResultMilitaryRankDto>>(ranks);
            return new SuccessDateResult<List<ResultMilitaryRankDto>>(result);
        }

        public async Task<IDataResult<List<ResultEmployeeRanksInfoDto>>> GetRankSEmployeeDetailsInfoAsync(int empID)
        {
            return new SuccessDateResult<List<ResultEmployeeRanksInfoDto>>(await _rankDal.GetEmployeeRankDetails(empID));
        }

        public async Task<IResult> MilitaryRankAddedAsycn(ResultMilitaryRankDto militaryRankDto)
        {
            var rank = _mapper.Map<MilitaryRank>(militaryRankDto);
            await _rankDal.AddAsync(rank);
            return new SuccessResult(Messages.EmployeeRankAdded);
        }

        public async Task<IResult> MilitaryRankdeletedAsync(ResultMilitaryRankDto militaryRankDto)
        {
            var rank = _mapper.Map<MilitaryRank>(militaryRankDto);
            await _rankDal.DeleteAsync(rank);
            return new SuccessResult(Messages.MilitaryRankDeleted);
        }

        public async Task<IResult> MilitaryRankUpdateAsycn(ResultMilitaryRankDto militaryRankDto)
        {
            var rank = _mapper.Map<MilitaryRank>(militaryRankDto);
            await _rankDal.UpdateAsync(rank);
            return new SuccessResult(Messages.MilitaryRankUpdated);
        }
    }
}
