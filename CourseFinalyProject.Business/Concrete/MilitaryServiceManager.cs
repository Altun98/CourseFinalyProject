using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MilitaryServiceManager : IMilitaryServiceService
    {
        private readonly IMilitaryServiceDal _militaryService;
        public MilitaryServiceManager(IMilitaryServiceDal militaryService)
        {
            _militaryService = militaryService;
        }

        public Task<IResult> AddAsync(CreateMilitaryServiceDto createMilitaryServiceDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(ResultMilitaryServiceDto resultMilitaryServiceDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpateAsync(UpdateMilitaryServiceDto updateMilitaryServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
