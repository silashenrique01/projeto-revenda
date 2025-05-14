using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class OrdemRevendaDto
    {
        public Guid Id { get; set; } = new Guid();
        public IList<ProdutoRevendaDto> Produtos { get; set; }

        public OrdemRevendaDto()
        {
            
        }
    }
}
