using Books.Integration.Interface;
using Microsoft.AspNetCore.Mvc;

namespace TomeOfKnowledge.Controllers
{
    public class BookController : Controller
    {
        private readonly IGetAllBooks _getAllBooks;

        public BookController(IGetAllBooks getAllBooks)
        {
            _getAllBooks = getAllBooks;
        }

        [HttpGet]
        public void GetAllBooks()
        {
            var books = _getAllBooks.GetAllBooksFromDatabase();
            // Call Service Call
            // what happens if I just add this comment
        }
    }
}