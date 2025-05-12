using System;
using System.Collections.Generic;

namespace Domain
{
    public class Revenda
    {
        public Guid RevendaId { get; private set; }
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Email { get; private set; }
        public IList<string> Telefones { get; private set; }
        public IList<Contato> Contatos { get; private set; }
        public IList<Endereco> Enderecos { get; private set; }

        public Revenda(string cnpj, string razaoSocial, string nomeFantasia, string email, IList<string> telefones, IList<Contato> contatos, IList<Endereco> enderecos)
        {
            RevendaId = Guid.NewGuid();
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Email = email;
            Telefones = telefones;
            Contatos = contatos;
            Enderecos = enderecos;
        }

        public void AdicionarTelefone(string telefone)
        {
            Telefones.Add(telefone);
        }

        public void AdicionarContato(Contato contato)
        {
            Contatos.Add(contato);
        }

        public void AdicionarEnderecoEntrega(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }

    }
}
