using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class ConscriptioManager : IConscriptioService
    {
        private readonly IConscriptioDal _conscriptio;
        public ConscriptioManager(IConscriptioDal conscriptio)
        {
            _conscriptio = conscriptio;
        }
    }
}
