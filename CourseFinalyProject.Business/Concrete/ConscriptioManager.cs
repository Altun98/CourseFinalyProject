using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
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

        public async Task<IResult> Added(ConscriptionDto conscriptionDto)
        {
            var conscriptio = _mapper.Map<Conscriptio>(conscriptionDto);
            await _conscriptio.Add(conscriptio);
            return new SuccessResult(Messages.ConscriptionAdded);
        }

        public async Task<IResult> Deleted(ConscriptionDto conscriptionDto)
        {
            var conscriptio = _mapper.Map<Conscriptio>(conscriptionDto);
            await _conscriptio.Delete(conscriptio);
            return new SuccessResult(Messages.ConscriptionDeleted);
        }

        public async Task<IDataResult<List<ConscriptionDto>>> GetAll()
        {
            var conscriptios = await _conscriptio.GetAll();
            var result = _mapper.Map<List<ConscriptionDto>>(conscriptios);
            return new SuccessDateResult<List<ConscriptionDto>>(result);
        }

        public async Task<IDataResult<List<ConscriptionDto>>> GetByID(int employeeID)
        {
            var conscriptios = await _conscriptio.GetAll(p => p.EmployeeID == employeeID);
            var result = _mapper.Map<List<ConscriptionDto>>(conscriptios);
            return new SuccessDateResult<List<ConscriptionDto>>(result);
        }

        public async Task<IDataResult<List<ConscriptionDepartamentDetailsDto>>> GetDepartamentID(int departamentId)
        {
            var result = await _conscriptio.GetConscriptionDepartamentDetails(departamentId);
            return new SuccessDateResult<List<ConscriptionDepartamentDetailsDto>>(result);
        }

        public Task<IResult> Updated(ConscriptionDto conscriptionDto)
        {
            throw new NotImplementedException();
        }
    }
}
