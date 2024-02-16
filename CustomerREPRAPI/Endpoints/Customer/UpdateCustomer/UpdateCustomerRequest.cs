using CustomerREPRAPI.Endpoints.Customer.CreateCustomer;

namespace CustomerREPRAPI.Endpoints.Customer.UpdateCustomer
{
    public class UpdateCustomerRequest : CreateCustomerRequest
    {
        public int Id { get; set; }
    }
}
