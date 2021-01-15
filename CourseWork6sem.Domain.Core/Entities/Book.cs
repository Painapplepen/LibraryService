using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork6sem.Domain.Core.Entities
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public int GenreId { get; set; }

        public int PublisherId { get; set; }

        public int PagesAmount { get; set; }

        public int Year { get; set; }
    }
}
