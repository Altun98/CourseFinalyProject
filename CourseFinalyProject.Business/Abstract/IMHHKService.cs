using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.MHHKDtos;
using log4net.DateFormatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMHHKService
    {
        Task<IResult> AddAsync(CreateMHHKDto createMHHKDto);
        Task<IResult> UpdateAsync(UpdateMHHKDto updateMHHKDto);
        Task<IResult> DeleteAsync(ResultMHHKDto resultMHHKDto);

        Task<IDataResult<List<ResultMHHKDto>>> GetAllAsync();
        Task<IDataResult<List<ResultMHHKDto>>> GetFindEmployee(int _empId);
        Task<IDataResult<ResultMHHKDto>> GetById(int _id);
        Task<IDataResult<List<ResultMHHKDto>>> GetFindMHHKDocNumber(string _number);
        Task<IDataResult<List<ResultMHHKDto>>> GetDocdateControl(DateTime _start, DateTime _end);
        Task<IDataResult<List<ResultMHHKDto>>> GetFindFeedback(string _feedback);
        Task<IDataResult<List<ResultMHHKDto>>> GetFindCompany(string _company);
        Task<IDataResult<List<ResultMHHKDto>>> GetFindDiagnosis(string _diagnosis);


    }
}
