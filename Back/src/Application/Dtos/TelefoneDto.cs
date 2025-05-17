using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class TelefoneDto
    {
        [Phone(ErrorMessage = "O número de telefone está inválido")]
        public string Numero { get; set; }

        public RevendaDto Revenda { get; set; }
        public Guid RevendaId { get; set; }
    }
}
