using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Books;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController:ControllerBase
    {

        private IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookDtoCreate book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var bookReturned = await _service.Post(book);
                if (bookReturned != null)
                {
                    return Ok(bookReturned);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException error)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException error)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (Exception error)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] BookDtoUpdate book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var updatedBook = await _service.Put(book);
                if (updatedBook != null)
                {
                    return Ok(updatedBook);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException error)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                bool delete = await _service.Delete(id);
                return Ok(delete);
            }
            catch (Exception error)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, error.Message);
            }
        }

    }
}
