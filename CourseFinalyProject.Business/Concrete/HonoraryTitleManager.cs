using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.HonoraryTitleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class HonoraryTitleManager(IHonoraryTitleDal _honoraryTitleDal, IMapper _mapper) : IHonoraryTitleService
    {
        public async Task<IResult> AddAsync(CreateHonoraryTitleDto createHonoraryTitleDto)
        {
            var control = _mapper.Map<HonoraryTitle>(createHonoraryTitleDto);
            if (await HonoraryTitleDubilcartNameControl(control))
            {
                var value = _mapper.Map<HonoraryTitle>(createHonoraryTitleDto);
                await _honoraryTitleDal.AddAsync(value);
                if (value != null)
                    return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultHonoraryTitleDto resultHonoraryTitleDto)
        {
            var value = _mapper.Map<HonoraryTitle>(resultHonoraryTitleDto);
            await _honoraryTitleDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultHonoraryTitleDto>>> GetAllAsync()
        {
            var value = await _honoraryTitleDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultHonoraryTitleDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultHonoraryTitleDto>>(valMap);
            return new ErrorDataResult<List<ResultHonoraryTitleDto>>(valMap,Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateHonoraryTitleDto updateHonoraryTitleDto)
        {
            var contr = _mapper.Map<HonoraryTitle>(updateHonoraryTitleDto);
            if(await HonoraryTitleDubilcartNameControl(contr))
            {
                await _honoraryTitleDal.UpdateAsync(contr);
                if (contr != null)
                    return new SuccessResult(Messages.Updated);
            }
            return new ErrorResult(Messages.NoUpdate);
        }
        private async Task<bool> HonoraryTitleDubilcartNameControl(HonoraryTitle honoraryTitle)
        {
            var value = await _honoraryTitleDal.GetAsync(x => x.HonoraryTitleName.Contains(honoraryTitle.HonoraryTitleName));
            if (value != null)
                return false;
            return true;
        }
    }
}
