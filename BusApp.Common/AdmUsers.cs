using BusApp.Data.Entities;
using BusApp.Data.Managers;
using System.Collections.Generic;

namespace BusApp.Common
{
    public class AdmUsers
    {
        UserManager userManager = null;

        public List<User> GetRutas(string code = "")
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

        public void RutaPut(int opt, User ruta)
        {
            userManager = new UserManager("USER_PUT");
            userManager.Put(opt, ruta);
            userManager.Dispose();
        }
    }
}
