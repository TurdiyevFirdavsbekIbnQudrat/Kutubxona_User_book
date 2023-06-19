using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagemet
{
    public  abstract class LibraryManagementCore
    {
        public LibraryStore Store { get; set; }
        public LibraryManagementCore() 
        {
            Store = new LibraryStore();
        }
        
        public LibraryManagementCore(List<User>users,List<Book>books)
        {
            Store = new LibraryStore(books, users);
        }

        public void DisplayAllUsers()
        {
            foreach (var user in Store.Users)
            {
                Console.WriteLine(user);
            }
        }

        public void DisplayAllBooks()
        {

            foreach (var book in Store.Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
