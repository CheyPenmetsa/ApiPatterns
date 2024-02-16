namespace CustomerREPRAPI.Endpoints.Customer.GetCustomerById
{
    public class GetCustomerByIdResponse
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}
