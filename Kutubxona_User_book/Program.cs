using LibraryManagement;
using LibraryManagemet;
var libraryManagement = new LibraryManagementCore(DataSource.Users,DataSource.Books );

libraryManagement.DisplayAllBooks();
libraryManagement.DisplayAllUsers();