using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public interface IAuthor
    {
        public void Update(Author author);
        public void Save(Author author);
        public List<Author> GetAuthors();
        public void Delete(int id);
        public Author GetAuthor(int IdAuthor);
    }
}
