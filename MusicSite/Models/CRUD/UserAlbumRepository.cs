using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicSite.Models.CRUD
{
    public interface IUserAlbumRepository
    {
        IList<Album> FindByAlbumName(String albumName);
        IList<Album> FindByPage(int page, int size);
        Album FindById(int id);
    }
    public class UserAlbumRepository : IUserAlbumRepository
    {
        private AppDataBase context;
        public IList<Album> FindByAlbumName(string albumName)
        {
            throw new NotImplementedException();
        }

        public Album FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Album> FindByPage(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
