using BookStoreApi.Model;

namespace BookStoreApi.Data
{
    public class AuthorRepo:IAuthor
    {
        private readonly BookStoreContext _db;
        public AuthorRepo(BookStoreContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var author = _db.Authors.First(t => t.Id == id);
            if (author != null)
            {
                _db.Authors.Remove(author);
                _db.SaveChanges();
            }

        }



        public List<Author> GetAuthors()
        {
            return _db.Authors.ToList();
        }

        public Author GetAuthor(int IdAuthor)
        {
            var author = _db.Authors.FirstOrDefault(t => t.Id == IdAuthor);
            if (author != null) return author;
            else return null;

        }

        public void Save(Author author)
        {
            if (author.Id == 0)
            {
                _db.Authors.Add(author);
                _db.SaveChanges();
            }
        }


        public void Update(Author author)
        {
            var authorEntity = _db.Authors.First(t => t.Id == author.Id);
            if (authorEntity != null)
            {
                authorEntity.Name = author.Name;
                authorEntity.BirthDate = author.BirthDate;
                
                _db.SaveChanges();
            }
        }


    }
}
