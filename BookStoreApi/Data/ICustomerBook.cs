using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public interface ICustomerBook
    {
        public void Update(CustomerBook customer);
        public void Save(CustomerBook customer);
        public List<CustomerBook> GetCustomerBooks();
        public void Delete(int id);
        public CustomerBook GetCustomerBook(int IdBookCustomer);
    }
}
