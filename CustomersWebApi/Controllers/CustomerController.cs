using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomersWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("GetCustomer")]
        [Authorize]
        public JsonResult GetCustomer()
        {
            var model = new Customer()
            {
                Name = "Onur",
                Surname = "Caylak"
            };
            return new JsonResult(new
            {
                Data = new
                {
                    Name=model.Name,
                    Surname=model.Surname
                }
            });
        }

        [HttpGet("GetPrivateCustomer")]
        [Authorize(Roles="Administrator")]
        public JsonResult GetPrivateCustomer()
        {
            var model = new Customer()
            {
                Name = "Onur",
                Surname = "Private"
            };
            return new JsonResult(new
            {
                Data = new
                {
                    Name = model.Name,
                    Surname = model.Surname
                }
            });
        }
        [HttpGet("GetCommonCustomer")]
        [Authorize(Roles = "Administrator,User")]
        public JsonResult GetCommonCustomer()
        {
            var model = new Customer()
            {
                Name = "Onur",
                Surname = "Ortak"
            };
            return new JsonResult(new
            {
                Data = new
                {
                    Name = model.Name,
                    Surname = model.Surname
                }
            });
        }

    }
}
