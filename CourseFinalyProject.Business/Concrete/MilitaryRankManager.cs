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
    public class MilitaryRankManager : IMilitaryRankService
    {

        private IMilitaryRankDal _rankDal;
        private IMapper _mapper;
        public MilitaryRankManager(IMilitaryRankDal rankDal, IMapper mapper)
        {
            _rankDal = rankDal;
            _mapper = mapper;
        }

        public async Task<IDataResult<List<MilitaryRankDto>>> GetAll()
        {
            var ranks = await _rankDal.GetAll();
            var result = _mapper.Map<List<MilitaryRankDto>>(ranks);
            return new SuccessDateResult<List<MilitaryRankDto>>( result);
        }

        public async Task<IDataResult<List<MilitaryRankDto>>> GetEmployeeRanksInfo(int empID)
        {
            var ranks = await _rankDal.GetAll(p => p.EmployeeID == empID);
            var result = _mapper.Map<List<MilitaryRankDto>>(ranks);
            return new SuccessDateResult<List<MilitaryRankDto>>(result);
        }

        public async Task<IDataResult<List<EmployeeRanksInfoDto>>> GetRankSEmployeeDetailsInfo(int empID)
        {
            return new SuccessDateResult<List<EmployeeRanksInfoDto>>(await _rankDal.GetEmployeeRankDetails(empID));
        }

        public async Task<IResult> MilitaryRankAdded(MilitaryRankDto militaryRankDto)
        {
            var rank = _mapper.Map<MilitaryRank>(militaryRankDto);
            await _rankDal.Add(rank);
            return new SuccessResult(Messages.EmployeeRankAdded);
        }

        public async Task<IResult> MilitaryRankdeleted(MilitaryRankDto militaryRankDto)
        {
            var rank = _mapper.Map<MilitaryRank>(militaryRankDto);
            await _rankDal.Delete(rank);
            return new SuccessResult(Messages.MilitaryRankDeleted);
        }

        public async Task<IResult> MilitaryRankUpdate(MilitaryRankDto militaryRankDto)
        {
            var rank = _mapper.Map<MilitaryRank>(militaryRankDto);
            await _rankDal.Update(rank);
            return new SuccessResult(Messages.MilitaryRankUpdated);
        }
    }
}
