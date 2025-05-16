using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class OrdemDto
    {
        public Guid Id { get; set; } = new Guid();
        public long ClienteId { get; set; }
        public IList<ProdutoDto> Produtos { get; set; }

        public Guid RevendaId { get; set; }

        public OrdemDto()
        {
           
        }
    }
}
