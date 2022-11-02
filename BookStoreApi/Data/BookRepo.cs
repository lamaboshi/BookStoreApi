using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public class BookRepo : IBook
    {
        private readonly BookStoreContext _db;
        public BookRepo(BookStoreContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {
            var book = _db.Books.First(t => t.Id == id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
            }
        }

        public Book GetBook(int IdBook)
        {
            var book = _db.Books.FirstOrDefault(t => t.Id == IdBook);
            if (book != null) return book;
            else return null;
        }

        public List<Book> GetBooks()
        {
            return _db.Books.ToList();
        }

        public void Save(Book book)
        {
            if (book.Id == 0)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
            }
        }

        public void Update(Book book)
        {
            var bookEntity = _db.Books.First(t => t.Id == book.Id);
            if (bookEntity != null)
            {
                bookEntity.Image = book.Image;
                bookEntity.Price = book.Price;
                bookEntity.NameBook = book.NameBook;
                bookEntity.PublichDate = bookEntity.PublichDate;

                _db.SaveChanges();
            }
        }
    }
}
