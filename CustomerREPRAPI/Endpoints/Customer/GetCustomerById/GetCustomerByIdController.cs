using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace CustomerREPRAPI.Endpoints.Customer.GetCustomerById
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    [ApiController]
    public class GetCustomerByIdController : ControllerBase
    {
        [HttpGet("{id}", Name = "GetCustomerById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [SwaggerOperation(Tags = new[] { "Customer" })]
        public ActionResult GetCustomerByIdAsync(int id)
        {
            return Ok(new GetCustomerByIdResponse { CustomerId = id });
        }
    }
}
