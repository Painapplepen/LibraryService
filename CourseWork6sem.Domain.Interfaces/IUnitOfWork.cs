using CourseWork6sem.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork6sem.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Admin> Admins { get; }
        
        IRepository<Author> Authors { get; }
        
        IRepository<Book> Books { get; }
        
        IRepository<BookFound> BookFounds { get; }
        
        IRepository<Genre> Genres { get; }

        IRepository<Library> Libraries { get; }

        IRepository<Publisher> Publishers { get; }

        void Save();
    }
}
