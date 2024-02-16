namespace CustomerREPRAPI.Endpoints.Customer.CreateCustomer
{
    public class CreateCustomerRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}
