using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BooksWCFServiceLib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class BooksService : IBooksService
    {
        List<Book> books = new List<Book> {
            new Book ( "MyBook", "The best book!", 1993, true ),
            new Book ( "Second Book", "Not the best book!", 1993, false ),
            new Book ( "Third Book", "The worst book!", 2010, true )
        };

        
        public string getInfo (string name) {
            Book book = books.FirstOrDefault(n => n.Name == name);
            if (book == null)
            {
                return "Error. Not found.";
            }
            else
            {
                return book.Info;
            }
        }

        public List<string> getBooksByYear(int year)
        {
            return books.Where(book => book.Year == year).Select(book => book.Name).ToList();
        }

        public List<string> getAvailableBooks()
        {
            return books.Where(book => book.Availabe).Select(book => book.Name).ToList();
        }
    
    }
}
