using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Dtos
{
    public class RevendaDto
    {
        public string Cnpj { get;  set; }
        public string RazaoSocial { get;  set; }
        public string NomeFantasia { get;  set; }
        public string Email { get;  set; }
        public IList<string> Telefones { get;  set; }
        public IList<Contato> Contatos { get;  set; }
        public IList<Endereco> Enderecos { get;  set; }

        public RevendaDto()
        {

        }
    }
}
