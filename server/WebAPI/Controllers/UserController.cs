﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataAccess;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;
        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> Get()
        {

            IEnumerable<UserDTO> objectList = userService.GetUsers();
            return Ok(objectList);
        }        
        public ActionResult<User> Post(UserDTO user)
        {
            if (userService.isEmailInUse(user.Email))
            {
                ModelState.AddModelError("Email", "Данный e-mail уже зарегистрирован");
                return BadRequest(ModelState);
            }
            userService.CreateUser(user);
            return Ok(ModelState);
        }
    }
}