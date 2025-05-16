
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.Entities.DTOs.UserDtos;

namespace Business.Concrete
{

    public class AuthManager(IUserService _userService, ITokenHelper _tokenHelper) : IAuthService
    {

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
            var claims = await _userService.GetClaimsAsync(user);
            var accessToken = _tokenHelper.CreateToken(user, claims.Data);
            return new SuccessDateResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public async Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = await _userService.GetByMailAsync(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash,userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDateResult<User>(userToCheck.Data, Messages.SuccessfulLogin);

        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.AddAsync(user);
            return new SuccessDateResult<User>(user, Messages.SuccessfulLogin);
        }
        public async Task<IResult> UserExists(string email)
        {
            var result = await _userService.GetByMailAsync(email);
            if (result == null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
