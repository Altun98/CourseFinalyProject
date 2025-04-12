using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class BloodTypeManager : IBloodTypeService
    {
        private readonly IBloodTypeDal _bloodType;
        public BloodTypeManager(IBloodTypeDal bloodType)
        {
            _bloodType = bloodType;
        }
    }
}
