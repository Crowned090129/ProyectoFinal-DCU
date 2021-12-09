using BusApp.Data.Entities;
using BusApp.Data.Managers;
using System.Collections.Generic;

namespace BusApp.Common
{
    public  class AdmUser
    {
        UserManager userManager = null;

        public List<User> GetUsers(string code = "")
        {
            userManager = new UserManager("USER_GET");
            List<User> users = new List<User>();

            if (code != "")
                users = userManager.Get(code);
            else
                users = userManager.Get();

            userManager.Dispose();
            return users;
        }

        public void UserPut(int opt, User user)
        {
            userManager = new UserManager("USER_PUT");
            userManager.Put(opt, user);
            userManager.Dispose();
        }
    }
}
