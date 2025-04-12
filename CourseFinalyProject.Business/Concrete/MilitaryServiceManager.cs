using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MilitaryServiceManager : IMilitaryServiceService
    {
        private readonly IMilitaryServiceDal _militaryService;
        public MilitaryServiceManager(IMilitaryServiceDal militaryService)
        {
            _militaryService = militaryService;
        }
    }
}
