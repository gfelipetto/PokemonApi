using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InformaçõesDePokemon.Api.Models
{
    public class Pokemon
    {
        [Key]
        [Required]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Tipo é obrigatório")]
        public string Tipo { get; set; }
    }
}
