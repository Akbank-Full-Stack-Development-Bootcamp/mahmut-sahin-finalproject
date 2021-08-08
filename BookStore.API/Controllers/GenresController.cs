using AutoMapper.QueryableExtensions.Impl;
using BookStore.Business.DTOs;
using BookStore.Business.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService service;

        public GenresController(IGenreService service)
        {
            this.service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            var result = service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetById(int id)
        {
            var result = service.GetById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddGenre(AddGenreRequestDTO newGenre)
        {
            if (ModelState.IsValid)
            {
                int newId = service.Add(newGenre);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = newId }, null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGenre(int id, EditGenreRequestDTO request)
        {
            if (ModelState.IsValid)
            {
                int newId = service.UpdateGenre(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            service.DeleteGenre(id);
            return Ok();

        }
    }
}
