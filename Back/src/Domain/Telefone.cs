using System;

namespace Domain
{
    public class Telefone
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public Revenda Revenda { get; set; }
        public Guid RevendaId { get; set; }
    }
}
