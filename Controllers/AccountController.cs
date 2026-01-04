using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using SerilogPractice.Models.DTOs;
using SerilogPractice.Models.Entities;
using SerilogPractice.Models.ViewModels;

namespace SerilogPractice.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        public AccountController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var user = _mapper.Map<User>(model);
            Log.Information("Mapped User Entity: {@User}", user);
            var responce = _mapper.Map<UserResponseDto>(user);
            
            return View("Success", responce);

        }
    }
}
