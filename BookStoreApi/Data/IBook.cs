using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public interface IBook
    {
        public void Update( Book book);
        public void Save(Book book);
        public List<Book> GetBooks();
        public void Delete(int id);
        public Book GetBook(int IdBook);
    }
}
