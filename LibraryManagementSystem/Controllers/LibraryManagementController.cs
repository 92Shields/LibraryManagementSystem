using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace LibraryManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryManagementController : ControllerBase
    {
        private readonly ILogger<LibraryManagementController> _logger;

        public LibraryManagementController(ILogger<LibraryManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBooks")]
        public IEnumerable<Book> Get()
        {
            return new List<Book>();
        }

        [HttpGet(Name = "GetBook")]
        public Book Get(int id)
        {
            return new Book();
        }

        [HttpPost(Name = "AddBook")]
        public void Post(Book book)
        {
            return;
        }

        [HttpPatch(Name = "UpdateBook")]
        public void Patch(Book book)
        {
            return;
        }

        [HttpDelete(Name = "DeleteBook")]
        public void Delete(int id)
        {
            return;
        }
    }
}
