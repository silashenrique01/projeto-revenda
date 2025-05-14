using System;

namespace Domain
{
    public class Produto
    {
        public Guid Id { get; private set; }

        public int Quantidade { get; private set; }

        public Guid OrdemId { get; private set; }
        public Ordem Ordem { get; private set; }

        public Produto()
        {
                
        }
    }
}