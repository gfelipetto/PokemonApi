using System.ComponentModel.DataAnnotations;

namespace CadastraPokemon.Data.Dtos
{
    public class CriarPokemonDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Tipo é obrigatório")]
        public string Tipo { get; set; }
    }
}
