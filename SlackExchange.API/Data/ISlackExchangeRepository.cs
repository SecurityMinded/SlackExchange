using System.Collections.Generic;
using System.Threading.Tasks;
using SlackExchange.API.Models;

namespace SlackExchange.API.Data
{
    public interface ISlackExchangeRepository
    {
         void Add<T>(T entity) where T: class;

         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();

         Task<IEnumerable<User>> GetUsers();

         Task<User> GetUser(int id);
    }
}