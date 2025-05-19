using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.BranchDtos;
using CourseFinalyProject.Entities.DTOs.ConscriptionDtos;
using CourseFinalyProject.Entities.DTOs.DepartamentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class BranchManager(IBranchDal _branchDal, IMapper _mapper) : IBranchService
    {
        public async Task<IResult> AddAsync(CreateBranchDto createBranchDto)
        {
            var value = _mapper.Map<Branch>(createBranchDto);
            await _branchDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultBranchDto resultBranchDto)
        {
            var value = _mapper.Map<Branch>(resultBranchDto);
            await _branchDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultBranchDto>>> GetAllAsync()
        {
            var value = await _branchDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultBranchDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultBranchDto>>(valMap);
            return new ErrorDataResult<List<ResultBranchDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultBranchDto>>> GetFindBrancName(string name)
        {
            var value = await _branchDal.GetAllAsync(x => x.BranchName.Contains(name));
            var valMap = _mapper.Map<List<ResultBranchDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultBranchDto>>(valMap);
            return new ErrorDataResult<List<ResultBranchDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateBranchDto updateBranchDto)
        {
            var value = _mapper.Map<Branch>(updateBranchDto);
            await _branchDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
