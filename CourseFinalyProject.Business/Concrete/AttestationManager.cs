using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
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
        public AttestationManager(IAttestationDal attestation)
        {
            _attestation = attestation;
        }
    }
}
