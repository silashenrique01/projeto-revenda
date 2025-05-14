using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class TelefoneDto
    {
        [Phone(ErrorMessage = "O número de telefone está inválido")]
        public string Numero { get; set; }

        public RevendaDto RevendaDto { get; set; }
        public Guid RevendaDtoId { get; set; }
    }
}
