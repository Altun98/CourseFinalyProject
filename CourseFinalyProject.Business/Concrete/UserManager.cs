using Core.Entities.Concrete;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task<IResult> AddAsync(User user)
        {
            await _userDal.AddAsync(user);
            return new SuccessResult();
        }

      

        public async Task<IDataResult<User>> GetByMailAsync(string email)
        {
            var result = await _userDal.GetAsync(u => u.Email == email);
            return new SuccessDateResult<User>(result);

        }

       
        public async Task<IDataResult<List<OperationClaim>>> GetClaimsAsync(User user)
        {
            var result = await _userDal.GetClaims(user);
            return new SuccessDateResult<List<OperationClaim>>(result);
        }

       
    }

}
