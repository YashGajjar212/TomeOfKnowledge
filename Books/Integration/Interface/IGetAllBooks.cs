using Books.ModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Integration.Interface
{
    public interface IGetAllBooks
    {
        public List<Book> GetAllBooksFromDatabase();
    }
}