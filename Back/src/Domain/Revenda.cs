using System;
using System.Collections.Generic;

namespace Domain
{
    public class Revenda
    {
        public Guid Id { get; private set; }
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Email { get; private set; }
        public IList<Telefone> Telefones { get; private set; }
        public IList<Contato> Contatos { get; private set; }
        public IList<Endereco> Enderecos { get; private set; }

        public IList<Ordem> Ordens { get; private set; }

        public Revenda()
        {
            
        }

    }
}
