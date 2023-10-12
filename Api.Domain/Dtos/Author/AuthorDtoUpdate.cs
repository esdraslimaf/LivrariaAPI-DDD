using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Author
{
    public class AuthorDtoUpdate // Usado para atualizar os dados de um usuário existente. Geralmente, contém os campos que podem ser atualizados.
    {
        [Required(ErrorMessage ="O campo Id é obrigatório!")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(65, ErrorMessage = "Tamanho máximo permitido é de {1} caracteres.")]
        public string Name { get; set; }

    }
}
