using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public class CustomerBookRepo : ICustomerBook
    {
        private readonly BookStoreContext _db;
        public CustomerBookRepo(BookStoreContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {

        }

        public CustomerBook GetCustomerBook(int IdBookCustomer)
        {
            var value = _db.CustomerBooks.FirstOrDefault(t => t.Id == IdBookCustomer);
            if (value != null) return value;
            else return null;
        }

        public List<CustomerBook> GetCustomerBooks()
        {
            return _db.CustomerBooks.ToList();
        }

        public void Save(CustomerBook customer)
        {
            if (customer.Id == 0)
            {
                _db.CustomerBooks.Add(customer);
                _db.SaveChanges();
            }
        }

        public void Update(CustomerBook customer)
        {
            throw new NotImplementedException();
        }
    }
}
