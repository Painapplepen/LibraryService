using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork6sem.Domain.Core.Entities
{
    public class BookFound
    {

        public int Id { get; set; }

        public string BookId { get; set; }

        public int LibraryId { get; set; }

        public int Amount { get; set; }

        public string Login { get; set; }
    }
}
