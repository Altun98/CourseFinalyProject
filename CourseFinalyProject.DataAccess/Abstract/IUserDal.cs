using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
       Task< List<OperationClaim>> GetClaims(User user);
    }
}
