using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Revenda
    {
        public Guid Id { get; private set; }
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Email { get; private set; }

        [NotMapped]
        public IList<Telefone> Telefones { get; private set; }
        public IList<Contato> Contatos { get; private set; }
        public IList<Endereco> Enderecos { get; private set; }

        public Revenda()
        {
            
        }

        public Revenda(string cnpj, string razaoSocial, string nomeFantasia, string email, IList<Telefone> telefones, IList<Contato> contatos, IList<Endereco> enderecos)
        {
            Id = Guid.NewGuid();
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Email = email;
            Telefones = telefones;
            Contatos = contatos;
            Enderecos = enderecos;
        }

        public void AdicionarTelefone(Telefone telefone)
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

        public void update(Guid id)
        {
            Id = id;
        }

    }
}
