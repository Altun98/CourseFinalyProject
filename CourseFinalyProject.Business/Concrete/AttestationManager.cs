using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
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

        public async Task<IResult> Added(AttestationDto attestationDto)
        {
            var result = _mapper.Map<Attestation>(attestationDto);
            await _attestation.Add(result);
            return new SuccessResult();
        }

        public async Task<IResult> Deleted(AttestationDto attestationDto)
        {
            var result = _mapper.Map<Attestation>(attestationDto);
            await _attestation.Delete(result);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<AttestationDto>>> GetAll()
        {
            var result = _mapper.Map<List<AttestationDto>>(await _attestation.GetAll());
            return new SuccessDateResult<List<AttestationDto>>(result);
        }

        public async Task<IDataResult<List<EmployeesAttestationDot>>> GetEmployeesAttestationsInfo(int empId)
        {
            return new SuccessDateResult<List<EmployeesAttestationDot>>(await _attestation.GetEmployeesAttestationsInfo(empId));
        }

        public async Task<IResult> Updated(AttestationDto attestationDto)
        {
            var result = _mapper.Map<Attestation>(attestationDto);
            await _attestation.Update(result);
            return new SuccessResult();
        }
    }
}
