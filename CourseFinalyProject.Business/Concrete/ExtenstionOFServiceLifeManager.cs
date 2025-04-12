using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class ExtenstionOFServiceLifeManager : IExtenstionOFServiceLifeService
    {
        private readonly IExtenstionOFServiceLifeDal _extenstionOFServiceLife;
        public ExtenstionOFServiceLifeManager(IExtenstionOFServiceLifeDal extenstionOFServiceLife)
        {
            _extenstionOFServiceLife = extenstionOFServiceLife;
        }
    }
}
