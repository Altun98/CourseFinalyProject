using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class DodtGoAbroadManager : IDodtGoAbroadService
    {
        private readonly IDodtGoAbroadDal _dodtGoAbroad;
        public DodtGoAbroadManager(IDodtGoAbroadDal dodtGoAbroad)
        {
            _dodtGoAbroad = dodtGoAbroad;
        }
    }
}
