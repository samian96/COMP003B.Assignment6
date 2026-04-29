using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment6.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        // NAvigation property collection

        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }

        // new property added before Db migration

        public string PublishDate { get; set; }
    }
}
