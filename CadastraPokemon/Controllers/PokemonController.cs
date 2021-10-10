using AutoMapper;
using CadastraPokemon.Data;
using CadastraPokemon.Data.Dtos;
using InformaçõesDePokemon.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InformaçõesDePokemon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private PokemonContexto _contexto;
        private IMapper _mapper;
        public PokemonController(PokemonContexto ctx, IMapper mapper)
        {
            _contexto = ctx;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarPokemon([FromBody] CriarPokemonDto pokemonDto)
        {
            Pokemon p = _mapper.Map<Pokemon>(pokemonDto);
            _contexto.Pokemon.Add(p);
            _contexto.SaveChanges();
            return CreatedAtAction(nameof(RecuperarPokemonPorId), new { id = p.Codigo}, p);
        }

        [HttpGet]
        public IActionResult RecuperarPokemon()
        {
            return Ok(_contexto.Pokemon);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPokemonPorId(int id)
        {
            Pokemon p = _contexto.Pokemon.FirstOrDefault(p => p.Codigo == id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverPokemon(int id)
        {
            Pokemon p = _contexto.Pokemon.FirstOrDefault(p => p.Codigo == id);
            if (p == null) return NotFound();

            _contexto.Remove(p);
            _contexto.SaveChanges();
            return NoContent();
        }
    }
}
