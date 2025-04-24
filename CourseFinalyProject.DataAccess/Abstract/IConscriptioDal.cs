using Core.DataAccess;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
    public interface IConscriptioDal : IEntityRepository<Conscriptio>
    {
        Task<List<ConscriptionDepartamentDetailsDto>> GetConscriptionDepartamentDetails(int departamentId);
    }
}
