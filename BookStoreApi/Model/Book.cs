namespace BookStoreApi.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string  NameBook { get; set; }
        public DateTime? PublichDate { get; set; }
        public int Price { get; set; }
        public byte[] Image { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<CustomerBook> CustomerBooks { get; set; }
    }
}
