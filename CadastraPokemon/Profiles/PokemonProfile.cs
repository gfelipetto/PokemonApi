
using AutoMapper;
using CadastraPokemon.Data.Dtos;
using InformaçõesDePokemon.Api.Models;

namespace CadastraPokemon.Profiles
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<CriarPokemonDto, Pokemon>();
            CreateMap<Pokemon, CriarPokemonDto>();
        }
    }
}
