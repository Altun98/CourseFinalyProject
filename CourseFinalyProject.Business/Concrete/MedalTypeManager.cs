using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.MedalTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MedalTypeManager(IMedalTypeDal _medalTypeDal, IMapper _mapper) : IMedalTypeService
    {
        public async Task<IResult> AddAsync(CreateMedalTypeDto createMedalTypeDto)
        {
            if (await MedalTypeControl(createMedalTypeDto))
            {
                var value = _mapper.Map<MedalType>(createMedalTypeDto);
                await _medalTypeDal.AddAsync(value);
                if (value != null)
                    return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.NoAdded);
        }

        public Task<IResult> DeleteAsync(ResultMedalTypeDto resultMedalTypeDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<ResultMedalTypeDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateMedalTypeDto updateMedalTypeDto)
        {
            throw new NotImplementedException();
        }
        private async Task<bool> MedalTypeControl(CreateMedalTypeDto createMedalTypeDto)
        {
            var value = await _medalTypeDal.GetAsync(x => x.MedalName.Contains(createMedalTypeDto.MedalName));
            if (value != null)
                return false;
            return true;
          
        }
    }
}
