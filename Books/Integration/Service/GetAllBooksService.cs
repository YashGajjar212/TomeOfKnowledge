using Books.Integration.Interface;
using Books.ModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Integration.Service
{
    public class GetAllBooksService : IGetAllBooks
    {
        public List<Book> GetAllBooksFromDatabase()
        {
            return null;
        }
    }
}