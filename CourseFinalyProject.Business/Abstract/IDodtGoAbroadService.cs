using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IDodtGoAbroadService
    {
        //xarice getme
        Task<IResult> Added(DodGoAbrodDto goAbrodDto);
        Task<IResult> Deleted(DodGoAbrodDto goAbrodDto);
        Task<IResult> Updated(DodGoAbrodDto goAbrodDto);
        Task<IDataResult<List<DodGoAbrodDto>>> GetAll();
        Task<IDataResult<List<DodGoAbrodDto>>> GetById(int empid);
        Task<IDataResult<List<DodGoAbrodDto>>> GetDataTimeControl(DateTime _start, DateTime _end);
        Task<IDataResult<List<DodGoAbrodDto>>> GetCountry(string country);
    }
}
