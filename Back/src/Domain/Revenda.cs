using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Revenda
    {
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public IList<string> Telefones { get; set; }
        public IList<Contato> Contatos { get; set; }
        public IList<Endereco> Enderecos { get; set; }

        public Revenda()
        {
            
        }

        //public Revenda(string cnpj, string razaoSocial, string nomeFantasia, string email, IList<string> telefones, IList<Contato> contatos, IList<Endereco> enderecos)
        //{
        //    Id = Guid.NewGuid();
        //    Cnpj = cnpj;
        //    RazaoSocial = razaoSocial;
        //    NomeFantasia = nomeFantasia;
        //    Email = email;
        //    Telefones = telefones;
        //    Contatos = contatos;
        //    Enderecos = enderecos;
        //}

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

        public void update(Guid id)
        {
            Id = id;
        }

    }
}
