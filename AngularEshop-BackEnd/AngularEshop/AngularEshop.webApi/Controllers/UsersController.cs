using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.Core.Utilities.Common;
using AngularEshop.DataLayer.Entities.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.webApi.Controllers
{
   
    
    public class UsersController : SiteBaseController
    {
        #region constructor
        private IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;

        }
        #endregion
        [HttpGet("Users")]
        public async Task<IActionResult> Users()
        {
            var users = await userService.GetAllUsers();

            return JsonResponseStatus.Success(users);
           
        }
    }
}
