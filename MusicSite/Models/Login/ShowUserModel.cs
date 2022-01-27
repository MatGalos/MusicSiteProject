using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MusicSite.Models.Login
{
    public class ShowUserModel
    {
        public ShowUserModel(User user, string userID)
        {
            this.UserName = user.UserName;
            this.ItsMe = user.Id == userID;

        }

        public string UserName { get; }
        public Boolean ItsMe { get; }
    }
}
