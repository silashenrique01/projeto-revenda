using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contato
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public bool ContatoPrincipal { get; private set; }

        public Contato(string nome, string sobrenome, bool contatoPrincipal)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            ContatoPrincipal = contatoPrincipal;

        }
    }
}
