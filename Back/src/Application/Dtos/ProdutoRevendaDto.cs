using System;

namespace Application.Dtos
{
    public class ProdutoRevendaDto
    {
        public Guid Id { get; set; } = new Guid();

        public int Quantidade { get; set; }
        public Guid OrdemRevendaId { get; set; }
        public OrdemRevendaDto OrdemRevenda { get; set; }

        public ProdutoRevendaDto()
        {

        }
    }
}
