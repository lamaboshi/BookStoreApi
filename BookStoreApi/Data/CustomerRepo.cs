using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public class CustomerRepo : ICustomer
    {
        private readonly BookStoreContext _db;
        public CustomerRepo(BookStoreContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {
            var value = _db.Customers.First(t => t.Id == id);
            if (value != null)
            {
                _db.Customers.Remove(value);
                _db.SaveChanges();
            }
        }

        public Customer GetCustomer(int IdBookCustomer)
        {
            var value = _db.Customers.FirstOrDefault(t => t.Id == IdBookCustomer);
            if (value != null) return value;
            else return null;
        }

        public List<Customer> GetCustomers()
        {
            return _db.Customers.ToList();
        }

        public void Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            var customerEntity = _db.Customers.First(t => t.Id == customer.Id);
            if (customerEntity != null)
            {
                customerEntity.Image = customer.Image;
                customerEntity.Name = customer.Name;
                customerEntity.Phone = customer.Phone;
               

                _db.SaveChanges();
            }
        }
    }
}
