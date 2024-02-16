using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace CustomerREPRAPI.Endpoints.Customer.CreateCustomer
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCustomerController : ControllerBase
    {
        [HttpPost(Name = "CreateCustomer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [SwaggerOperation(Tags = new[] { "Customer" })]
        public ActionResult CreateCustomerAsync(CreateCustomerRequest createCustomerRequest)
        {
            //TODO: Implement logic like validation, mapping etc.
            return NoContent();
        }
    }
}
