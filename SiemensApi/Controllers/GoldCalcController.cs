using Microsoft.AspNetCore.Mvc;
using SiemensApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiemensApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldCalcController : ControllerBase
    {
        // GET: api/<GoldCalc>
        [HttpGet]
        public String Get()
        {
            return "Gold Calculator";
        }

       

        // POST api/<GoldCalc>
        [HttpPost]
        public ResponseMessage Post([FromBody] GoldModel goldModel)
        {
            ResponseMessage response = new ResponseMessage();
            try
            {

                response.MsgType = "S";
                response.Msg = (goldModel.GoldRate * goldModel.GoldWeight -
                    goldModel.GoldRate * goldModel.GoldWeight * goldModel.GoldDiscount * 0.01).ToString("0.00");
            }
            catch (Exception ex)
            {
                //log exec
            }
            return response;
        }
    }
}
