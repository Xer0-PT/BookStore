using EGAPI.DTOs;
using EGAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        /// <summary>
        /// Get all Authors
        /// </summary>
        /// <returns>The list of all Authors</returns>
        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorDTO>>> GetAuthors()
        {
            var authors = await _authorService.GetAllAuthors();

            return Ok(authors);
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorDTO>> GetAuthor(int id)
        {
            var author = await _authorService.GetAuthorByID(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        // PUT: api/Authors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(int id, AuthorDTO author)
        {
            if (id != author.Id)
            {
                return BadRequest();
            }
            
            var result = await _authorService.UpdateAuthor(id, author);

            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }



        /// <summary>
        /// Creates an Author
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Authors
        ///     {   
        ///       "id": "1"
        ///       "name": "Mike",
        ///       "lastname": "Andrew",
        ///     }
        /// </remarks>
        /// /// <param name="author"></param>
        /// <returns>A newly created author</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>  
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Produces("application/json")]
        public async Task<ActionResult<AuthorDTO>> PostAuthor(AuthorDTO author)
        {
            await _authorService.NewAuthor(author);
            return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var author = await _authorService.DeleteAuthor(id);

            if (author == null)
            {
                return NotFound();
            }


            return NoContent();
        }

        
    }
}
