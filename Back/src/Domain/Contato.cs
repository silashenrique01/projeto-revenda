using System;

namespace Domain
{
    public class Contato
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public bool ContatoPrincipal { get; private set; }
        public Guid RevendaId { get; private set; }
        public Revenda Revenda { get; private set; }

        public Contato()
        {
            
        }

        public Contato(string nome, string sobrenome, bool contatoPrincipal)
        {
            Id = new Guid();
            Nome = nome;
            Sobrenome = sobrenome;
            ContatoPrincipal = contatoPrincipal;

        }
    }
}
