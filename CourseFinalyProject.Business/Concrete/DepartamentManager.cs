using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class DepartamentManager : IDepartamentService
    {
        private readonly IDepartamentDal _departament;
        public DepartamentManager(IDepartamentDal departament)
        {
            _departament = departament;
        }
    }
}
