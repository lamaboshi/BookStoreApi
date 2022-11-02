namespace BookStoreApi.Model
{
    public class CustomerBook
    {
        public int Id { get; set; }
        public int title { get; set; }
        public int CountBook { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
