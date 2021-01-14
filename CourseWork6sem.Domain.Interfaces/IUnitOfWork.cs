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

        IRepository<Admin> Comments { get; }
        IRepository<Company> Companies { get; }
        IRepository<VideoGame> VideoGames { get; }
        IRepository<Order> Orders { get; }
        IRepository<GameGenre> GameGenres { get; }

        void Save();
    }
}
