using Clinic.UI.Services.Interface;
using Clinic.UI.Services.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using static Azure.Core.HttpHeader;

namespace Clinic.UI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessService _businessService;

        public BusinessController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        [AllowAnonymous]
        [HttpPost("/RegisterBusinessUser")]
        public IActionResult RegisterBusinessUser([FromBody] BusinessModel model)
        {
            //try
            //{
            _businessService.RegisterBusinessUser(model);
            return Ok();
            //}
            //catch (AppException ex)
            //{
            //    Logger.LogError(ex.Message);
            //    return BadRequest(new ResponseModel() { Code = ex.ErrorCode, Message = ex.err_msg });
            //}
        }
    }
}