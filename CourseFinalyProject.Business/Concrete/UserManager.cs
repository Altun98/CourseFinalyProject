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

        public async Task<IResult> Add(User user)
        {
            await _userDal.Add(user);
            return new SuccessResult();
        }

        public async Task<IDataResult<User>> GetByMail(string email)
        {
            var result = await _userDal.Get(u => u.Email == email);
            return new SuccessDateResult<User>(result);

        }

        public async Task<IDataResult<List<OperationClaim>>> GetClaims(User user)
        {
            var result = await _userDal.GetClaims(user);
            return new SuccessDateResult<List<OperationClaim>>(result);
        }
    }

}
