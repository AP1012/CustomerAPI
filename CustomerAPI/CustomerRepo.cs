
namespace CustomerAPI
{
    public class CustomerRepo : ICustomerRepo
    {
        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Akarsh", LastName = "ptl" },
            new Customer { Id = 2, FirstName = "aka", LastName = "ptl" },
            
        };
        }
    }
}
