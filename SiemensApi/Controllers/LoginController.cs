using Microsoft.AspNetCore.Mvc;
using SiemensApi.DataBase;
using SiemensApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiemensApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/<Login>
        [HttpGet]
        public String Get()
        {
            return "Login with post request";
        }

        [HttpPost]
        public ResponseMessage Post([FromBody] UserModel userModel)
        {
            ResponseMessage response = new ResponseMessage();
            try
            {
                if (string.IsNullOrEmpty(userModel.UserId))
                {
                    response.MsgType = "F";
                    response.Msg = "Please enter user id";
                }
                else if (string.IsNullOrEmpty(userModel.Password))
                {
                    response.MsgType = "F";
                    response.Msg = "Please enter password";
                }
                else
                {
                    UserModel userModelDb = DummyUserDB.dummUser.Where(x => x.UserId.ToUpper() == userModel.UserId.ToUpper()
                                                                    && x.Password == userModel.Password).FirstOrDefault();
                    if (userModelDb == null)
                    {
                        response.MsgType = "F";
                        response.Msg = "User Id/Password is wrong";
                    }
                    else
                    {
                        response.MsgType = "T";
                        response.Msg = userModelDb.OrgCategory;
                    }
                }

            }
            catch (Exception ex)
            {
                //log exec
            }
          
          
            return response;
        }




    }
}
