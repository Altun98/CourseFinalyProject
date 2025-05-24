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

        public Task<IResult> DeleteAsync(ResultHonoraryTitleDto resultHonoraryTitleDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<ResultHonoraryTitleDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateHonoraryTitleDto updateHonoraryTitleDto)
        {
            throw new NotImplementedException();
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
