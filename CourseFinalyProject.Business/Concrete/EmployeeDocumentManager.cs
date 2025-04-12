using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class EmployeeDocumentManager : IEmployeeDocumentService
    {
        private readonly IEmployeeDocumentDal _employeeDocument;
        public EmployeeDocumentManager(IEmployeeDocumentDal employeeDocument)
        {
            _employeeDocument = employeeDocument;
        }
    }
}
