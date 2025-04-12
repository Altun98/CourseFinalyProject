using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class DiscountedServiceManager : IDiscountedServiceService
    {
        private readonly IDiscountedServiceDal _discountedService;
        public DiscountedServiceManager(IDiscountedServiceDal discountedService)
        {
            _discountedService = discountedService;
        }
    }
}
