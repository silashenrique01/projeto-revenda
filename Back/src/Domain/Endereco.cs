using System;

namespace Domain
{
    public class Endereco
    {
        public Guid Id { get; private set; }
        public string Longradouro { get; private set; }
        public int Numero { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public string Complemento { get; private set; }

        public string PontoReferencia { get; private set; }

        public Guid RevendaId { get; private set; }
        public Revenda Revenda { get; private set; }

        public Endereco()
        {
            
        }

        public Endereco(string longradouro, int numero, string cep, string bairro, string cidade, string estado, string complemento, string pontoReferencia)
        {
            Id = new Guid();
            Longradouro = longradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            PontoReferencia = pontoReferencia;
        }

       

    }
}

