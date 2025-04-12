using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class FrutherEducationManager : IFrutherEducationService
    {
        private readonly IFrutherEducationDal _frutherEducation;
        public FrutherEducationManager(IFrutherEducationDal frutherEducation)
        {
            _frutherEducation = frutherEducation;
        }
    }
}
