using InformaçõesDePokemon.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastraPokemon.Data
{
    public class PokemonContexto : DbContext
    {
        public PokemonContexto(DbContextOptions<PokemonContexto> opt) : base (opt)
        {}
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
