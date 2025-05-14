using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class OrdemDto
    {
        public Guid Id { get; set; } = new Guid();
        public Guid ClienteId { get; set; } = new Guid();
        public IList<ProdutoDto> Produtos { get; set; }

        public OrdemDto()
        {
           
        }
    }
}
