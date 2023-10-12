using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthorService _service;
        public AuthorsController(IAuthorService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AuthorDtoCreate author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var userRetornado = await _service.Post(author);
                if (userRetornado != null)
                {
                    return Ok(userRetornado);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message); // Erro interno do servidor (500)
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
            catch (Exception erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message); // Erro interno do servidor (500)
            }


        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AuthorDtoUpdate autor)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var autorAtualizado = await _service.Put(autor);
                if (autorAtualizado != null)
                {
                    return Ok(autorAtualizado);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpDelete]
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
            catch (Exception erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }


        }


    }
}
