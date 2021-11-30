using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.CRUD
{
    public interface ICRUDUserRepository
    {
        User Find(int id);
        User Delete(int id);
        User Add(User user);
        User Update(User user);
        IList<User> FindAll();
    }
    public class CRUDUserRepository : ICRUDUserRepository
    {
        private AppDataBase _context;
        
        public CRUDUserRepository (AppDataBase context)
        {
            _context = context;
        }
        public User Add(User user)
        {
            var entity = _context.Users.Add(user).Entity;
            _context.SaveChanges();
            return entity;

        }

        public User Delete(int id)
        {
            var user = _context.Users.Remove(Find(id)).Entity;
            _context.SaveChanges();
            return user;
        }

        public User Find(int id)
        {
            return _context.Users.Find(id);
        }

        public IList<User> FindAll()
        {
            return _context.Users.ToList();
        }

        public User Update(User user)
        {
            var entity = _context.Users.Update(user).Entity;
            _context.SaveChanges();
            return entity;
        }
    }
}
