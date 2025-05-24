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
            var control = _mapper.Map<MedalType>(createMedalTypeDto);
            if (await MedalTypeControl(control))
            {
                var value = _mapper.Map<MedalType>(createMedalTypeDto);
                await _medalTypeDal.AddAsync(value);
                if (value != null)
                    return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultMedalTypeDto resultMedalTypeDto)
        {
            var value = _mapper.Map<MedalType>(resultMedalTypeDto);
            await _medalTypeDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultMedalTypeDto>>> GetAllAsync()
        {
            var values = await _medalTypeDal.GetAllAsync();
            var valMaps = _mapper.Map<List<ResultMedalTypeDto>>(values);
            if (values != null)
                return new SuccessDateResult<List<ResultMedalTypeDto>>(valMaps);
            return new ErrorDataResult<List<ResultMedalTypeDto>> (valMaps, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateMedalTypeDto updateMedalTypeDto)
        {
            var conVal = _mapper.Map<MedalType>(updateMedalTypeDto);
            if(await MedalTypeControl(conVal))
            {
                await _medalTypeDal.UpdateAsync(conVal);
                if (conVal != null)
                    return new SuccessResult(Messages.Updated);
            }
            return new ErrorResult(Messages.NoUpdate);
        }
        private async Task<bool> MedalTypeControl(MedalType medalType)
        {
            var value = await _medalTypeDal.GetAsync(x => x.MedalName.Contains(medalType.MedalName));
            if (value != null)
                return false;
            return true;          
        }
    }
}
