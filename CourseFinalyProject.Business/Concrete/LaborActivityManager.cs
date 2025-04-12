using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class LaborActivityManager : ILaborActivityService
    {
        private readonly ILaborActivityDal _laborActivity;
        public LaborActivityManager(ILaborActivityDal laborActivity)
        {
            _laborActivity = laborActivity;
        }
    }
}
