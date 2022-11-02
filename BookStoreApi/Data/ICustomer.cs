using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public interface ICustomer
    {
        public void Update(Customer customer);
        public void Save(Customer customer);
        public List<Customer> GetCustomers();
        public void Delete(int id);
        public Customer GetCustomer(int IdBookCustomer);
    }
}
