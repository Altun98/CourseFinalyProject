﻿using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService _authService) : ControllerBase
    {

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = await _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = await _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = await _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success) { return BadRequest(userExists.Message); }
            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = await _authService.CreateAccessToken(registerResult.Data);
            if (result.Success) { return Ok(result.Data); }
            return BadRequest(result.Message);
        }
    }
}
