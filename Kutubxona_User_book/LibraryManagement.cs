using LibraryManagemet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kutubxona_User_book
{
    internal class LibraryManagement:LibraryManagementCore
    {
            public void RegisterUser(string firstName,string lastName)
            {

            }
            public void RegisterUser(string firstName, string lastName,string userName)
            {
                var foundUser = false;
                foreach (var user in Store.Users)
                {
                if(userName==user.UserName)
                    {
                        foundUser = true;
                        break;
                    }
                if(foundUser)
                {
                    return;
                }
                Store.Users.Add(new User(firstName,lastName,userName));
                }

            }
        
    }
}
