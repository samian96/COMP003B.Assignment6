using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment6.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        // nullable properties

        public virtual Author? Author { get; set; }
        public virtual Book? Book { get; set; }
    }
}
