using System;
using System.Collections.Generic;

namespace Domain
{
    public class Ordem
    {
        public Guid Id { get; private set; }

        public Guid ClienteId { get; private set; }

        public IList<Produto> Produtos { get; private set; }

        public Ordem()
        {
            
        }

        public Ordem(Guid id, Guid clienteId, IList<Produto> produtos)
        {
            id = new Guid();
            ClienteId = clienteId;
            Produtos = produtos;
        }


    }
}
