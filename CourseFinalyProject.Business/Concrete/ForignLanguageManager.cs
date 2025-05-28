using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class ForignLanguageManager(IForignLanguageDal _forignLanguageDal, IMapper _mapper) : IForignLanguageService
    {
        public Task<IResult> AddAsync(CreateForignLanguage dto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(ResultForignLanguage dto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<ResultForignLanguage>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UpdateForignLanguag dto)
        {
            throw new NotImplementedException();
        }
    }
}
