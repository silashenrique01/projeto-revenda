using System;

namespace Application.Dtos
{
    public class ContatoDto
    {
        public string Nome { get;  set; }
        public string Sobrenome { get;  set; }
        public bool ContatoPrincipal { get;  set; }
        public Guid RevendaId { get;  set; }
        public RevendaDto Revenda { get;  set; }

        public ContatoDto()
        {
            
        }
    }
}
