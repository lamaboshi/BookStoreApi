namespace BookStoreApi.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public byte[] Image { get; set; }
        public ICollection<CustomerBook> CustomerBooks { get; set; }
        
    }
}
