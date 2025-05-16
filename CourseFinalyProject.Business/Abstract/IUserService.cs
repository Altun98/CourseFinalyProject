using Core.Entities.Concrete;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<List<OperationClaim>>> GetClaimsAsync(User user);
        Task<IResult> AddAsync(User user);
        Task<IDataResult<User>> GetByMailAsync(string email);
    }
}
