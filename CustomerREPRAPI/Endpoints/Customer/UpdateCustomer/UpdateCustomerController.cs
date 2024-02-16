using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace CustomerREPRAPI.Endpoints.Customer.UpdateCustomer
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateCustomerController : ControllerBase
    {
        [HttpPost(Name = "UpdateCustomer1")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [SwaggerOperation(Tags = new[] { "Customer" })]
        public ActionResult UpdateCustomer1Async(UpdateCustomerRequest updateCustomerRequest)
        {
            //TODO: Implement logic like validation, mapping etc.
            return NoContent();
        }

        //[HttpPost(Name = "UpdateCustomer2")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[SwaggerOperation(Tags = new[] { "Customer" })]
        //public ActionResult UpdateCustomer2Async(UpdateCustomerRequest updateCustomerRequest)
        //{
        //    //TODO: Implement logic like validation, mapping etc.
        //    return NoContent();
        //}
    }
}
