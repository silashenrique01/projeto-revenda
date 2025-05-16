using System;

namespace Application.Dtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; } = new Guid();

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Guid OrdemId { get; set; }
        public OrdemDto Ordem { get; set; }

        public ProdutoDto()
        {

        }
    }
}