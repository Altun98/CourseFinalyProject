using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.ConscriptionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class ConscriptioManager : IConscriptioService
    {
        private readonly IConscriptioDal _conscriptio;
        private readonly IMapper _mapper;
        public ConscriptioManager(IConscriptioDal conscriptio, IMapper mapper)
        {
            _conscriptio = conscriptio;
            _mapper = mapper;
        }

        public async Task<IResult> AddedAsync(ResultConscriptionDto conscriptionDto)
        {
            var conscriptio = _mapper.Map<Conscriptio>(conscriptionDto);
            await _conscriptio.AddAsync(conscriptio);
            return new SuccessResult(Messages.ConscriptionAdded);
        }

        public async Task<IResult> DeletedAsync(ResultConscriptionDto conscriptionDto)
        {
            var conscriptio = _mapper.Map<Conscriptio>(conscriptionDto);
            await _conscriptio.DeleteAsync(conscriptio);
            return new SuccessResult(Messages.ConscriptionDeleted);
        }

        public async Task<IDataResult<List<ResultConscriptionDto>>> GetAllAsync()
        {
            var conscriptios = await _conscriptio.GetAllAsync();
            var result = _mapper.Map<List<ResultConscriptionDto>>(conscriptios);
            return new SuccessDateResult<List<ResultConscriptionDto>>(result);
        }

        public async Task<IDataResult<List<ResultConscriptionDto>>> GetByIDAsync(int employeeID)
        {
            var conscriptios = await _conscriptio.GetAllAsync(p => p.EmployeeID == employeeID);
            var result = _mapper.Map<List<ResultConscriptionDto>>(conscriptios);
            return new SuccessDateResult<List<ResultConscriptionDto>>(result);
        }

        public async Task<IDataResult<List<ConscriptionDepartamentDetailsDto>>> GetDepartamentIdAsync(int departamentId)
        {
            var result = await _conscriptio.GetConscriptionDepartamentDetails(departamentId);
            return new SuccessDateResult<List<ConscriptionDepartamentDetailsDto>>(result);
        }

        public Task<IResult> UpdatedAsync(ResultConscriptionDto conscriptionDto)
        {
            throw new NotImplementedException();
        }
    }
}
