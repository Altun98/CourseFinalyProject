using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMilitaryServiceService
    {
        Task<IResult> AddAsync(CreateMilitaryServiceDto createMilitaryServiceDto);
        Task<IResult> UpateAsync(UpdateMilitaryServiceDto updateMilitaryServiceDto);
        Task<IResult> DeleteAsync(ResultMilitaryServiceDto resultMilitaryServiceDto);

    }
}
