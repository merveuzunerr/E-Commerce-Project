using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class UserAccountsController : CustomBaseController
    {

        private readonly IMapper _mapper;
        private readonly IService<UserAccount> _service;
        private readonly IUserAccountService _userAccountsService;

        public UserAccountsController(IMapper mapper, IService<UserAccount> service, IUserAccountService userAccountsService)
        {
            _mapper=mapper;
            _service=service;
            _userAccountsService=userAccountsService;
        }

        [HttpPost()]
        [Route("register/{id?}")]
        public async Task<IActionResult> AddUserAccount(UserAccountDto userDto, int id)
        {

            return CreateActionResult(await _userAccountsService.AddUserAccount(userDto, id));
        }

        [HttpPost()]
        [Route("login/{id?}")]
        public async Task<IActionResult> Login(LoginDto loginDto, int id)
        {
            return CreateActionResult(await _userAccountsService.Login(loginDto, id));

        }

        [HttpDelete]
        [Route("logout/{id}")]
        public async Task<IActionResult> Logout(int id)
        {
            return CreateActionResult(await _userAccountsService.LogOut(id));

        }

    }
}
