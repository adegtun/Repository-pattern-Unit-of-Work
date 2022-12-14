using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
