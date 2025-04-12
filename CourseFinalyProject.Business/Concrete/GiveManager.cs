using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class GiveManager : IGiveService
    {
        private readonly IGiveDal _giveDal;
        public GiveManager(IGiveDal giveDal)
        {
            _giveDal = giveDal;
        }
    }
}
