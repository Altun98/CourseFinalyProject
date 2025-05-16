using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AttestationDtos;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class AttestationManager : IAttestationService
    {
        private readonly IAttestationDal _attestation;
        private readonly IMapper _mapper;
        public AttestationManager(IAttestationDal attestation, IMapper mapper)
        {
            _attestation = attestation;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(ResultAttestationDto attestationDto)
        {
            var result = _mapper.Map<Attestation>(attestationDto);
            await _attestation.AddAsync(result);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(ResultAttestationDto attestationDto)
        {
            var result = _mapper.Map<Attestation>(attestationDto);
            await _attestation.DeleteAsync(result);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<ResultAttestationDto>>> GetAllAsync()
        {
            var result = _mapper.Map<List<ResultAttestationDto>>(await _attestation.GetAllAsync());
            return new SuccessDateResult<List<ResultAttestationDto>>(result);
        }

        public async Task<IDataResult<List<ResultEmployeesAttestationDot>>> GetEmployeesAttestationsInfoAsync(int empId)
        {
            return new SuccessDateResult<List<ResultEmployeesAttestationDot>>(await _attestation.GetEmployeesAttestationsInfo(empId));
        }

        public async Task<IResult> UpdateAsync(ResultAttestationDto attestationDto)
        {
            var result = _mapper.Map<Attestation>(attestationDto);
            await _attestation.UpdateAsync(result);
            return new SuccessResult();
        }
    }
}
