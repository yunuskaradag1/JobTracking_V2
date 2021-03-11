using JobTracking.Data.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTracking.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using JobTracking.Core;

namespace JobTracking.WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly ActivityManager _activityManager;
        public UserController(ActivityManager activityManager)
        {
            _activityManager = activityManager;
  

        }
        [HttpGet("GetItems")]

        public IActionResult GetItems()
        {
            return Execute(() =>
            {
                var query = (from u in _activityManager.repository.GetQuery()
                             select new ActivityDto
                             {
                              
                               Description = u.Description,
                                 Id = u.Id,
                           
                             }).ToList();
                return Ok(query);

            });
        }
    }
}
