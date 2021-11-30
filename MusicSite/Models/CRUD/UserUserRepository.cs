using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.CRUD
{
    public interface IUserUserRepository
    {
        IList<User> FindByUserName(String userName);
        IList<User> FindByPage(int page,int size);
        User FindById(int id);
    }
    public class UserUserRepository : IUserUserRepository
    {
        private AppDataBase context;
        
        public UserUserRepository(AppDataBase appDataBase)
        {
            context = appDataBase;
        }
        public User FindById(int id)
        {
            return context.Users.Find(id);
        }

        public IList<User> FindByPage(int page, int size)
        {
            return (from p in context.Users select p).OrderBy(p => p.userName).Skip((page - 1) * size).Take(size).ToList();
        }

        public IList<User> FindByUserName(string userName)
        {
            return (from p in context.Users where p.userName.Contains(userName) select p).ToList();
        }
    }
}
