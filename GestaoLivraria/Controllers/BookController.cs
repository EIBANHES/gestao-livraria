using GestaoLivraria.Communication.Requests;
using GestaoLivraria.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers
{

    public class BookController : DeviceController
    {


        [HttpPost("create-book")]
        [ProducesResponseType(typeof(ResponseCreatedBookJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] ResquestCreateBookJson request)
        {
            var book = new ResquestCreateBookJson
            {
                Id = 0,
                Titulo = "Teste",
                Autor = "Emanuel",
                Genero = "Comedia",
                Preco = 2.50f,
                Qntd_estoque = 10
            };

            return Created(string.Empty, book);
        }

        [HttpGet("all-books")]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var book = new List<Book>()
            {
                new Book { Id = 0, Titulo = "teste", Autor = "emanuel", Genero = "cinema", Preco =  2.3f, Qntd_estoque = 10},
                new Book { Id = 0, Titulo = "oi", Autor = "amanda", Genero = "romance", Preco =  2.3f, Qntd_estoque = 10}
            };

            return Ok(book);
        }

        [HttpPut("update-book")]
        [ProducesResponseType(typeof(RequestUpdateBookJson), StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpdateBookJson request)
        {
            return NoContent();
        }

        [HttpDelete("delete-book")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
