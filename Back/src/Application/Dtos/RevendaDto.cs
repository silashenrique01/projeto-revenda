using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class RevendaDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Cnpj { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage =" O campo deve conter no máximo 50 caracteres")]
        public string RazaoSocial { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = " O campo deve conter no máximo 50 caracteres")]
        public string NomeFantasia { get;  set; }

        [Display(Name ="e-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage ="Deve ser preenchido um e-mail válido")]
        public string Email { get;  set; }

        public IList<TelefoneDto> Telefones { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public IList<ContatoDto> Contatos { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public IList<EnderecoDto> Enderecos { get;  set; }

        public IList<OrdemDto> Ordens { get; set; }

        public RevendaDto()
        {

        }
    }
}
