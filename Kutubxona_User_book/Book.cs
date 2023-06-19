using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagemet
{
    public class Book
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Guid? ReaderId { get; set; }
        public Book(string name, string author,string description,string category)
        {
            Description = description;
            Id = Guid.NewGuid();
            Name = name;
            Author = author;
            Category = category;
        }
        public override string ToString()
        {
            return $"Kitob" +
                $"\nid : {Id} ," +
                $"\nnomi : {Name} ," +
                $"\nmuallifi : {Author} , " +
                $"\nkim o'qiyapti : {ReaderId}\n";
        }
    }

    
}
