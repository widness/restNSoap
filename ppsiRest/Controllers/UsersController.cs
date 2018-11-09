using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrintPaySysIntegration.Controllers
{
    [RoutePrefix("api/user")]
    public class UsersController : ApiController
    {
        [Route("{uid:int}")]
        [HttpGet]
        public IHttpActionResult GetUsername(int uid)
        {
            string username = UserManager.GetUsername(uid);

            return Ok(username);

        }

        [Route("{username}")]
        [HttpGet]
        public IHttpActionResult GetAmount(string username)
        {
            double availableAmount = UserManager.GetAvailableAmount(username);

            return Ok(availableAmount);
  
        }

        // Post
        //[Route("")]
        //[HttpPost]
        //public IHttpActionResult AddAmount([FromBody]User user)
        //{
        //    double availableAmount = UserManager.AddAmount(user.UID, user.username);

        //    return Ok(availableAmount);
        //}
    }
}