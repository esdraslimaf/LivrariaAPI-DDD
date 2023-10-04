using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController:ControllerBase
    {
        private IAuthorService _service;
         public AuthorsController(IAuthorService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AuthorEntity author)
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

    }
}
