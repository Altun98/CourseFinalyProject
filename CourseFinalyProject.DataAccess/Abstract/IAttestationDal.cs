using Core.DataAccess;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
    public interface IAttestationDal : IEntityRepository<Attestation>
    {
        Task<List<EmployeesAttestationDot>> GetEmployeesAttestationsInfo(int empID);
    }
}
