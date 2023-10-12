using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Author
{
    public class AuthorDtoCreate //Usado para criar um novo usuário, contém os campos necessários para o processo de criação.
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(65, ErrorMessage = "Tamanho máximo permitido é de {1} caracteres.")]
        public string Name { get; set; }  
       
    }
}
