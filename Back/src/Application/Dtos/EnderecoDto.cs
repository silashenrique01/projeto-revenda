using System;
using Domain;

namespace Application.Dtos
{
    public class EnderecoDto
    {
        public string Longradouro { get;  set; }
        public int Numero { get;  set; }
        public string Cep { get;  set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Estado { get;  set; }

        public string Complemento { get;  set; }

        public string PontoReferencia { get;  set; }

        public Guid RevendaId { get;  set; }
        public RevendaDto Revenda { get;  set; }

        public EnderecoDto()
        {
            
        }

        //public Endereco(string longradouro, int numero, int cep, string bairro, string cidade, string estado, string complemento, string pontoReferencia)
        //{
        //    Id = Guid.NewGuid();
        //    Longradouro = longradouro;
        //    Numero = numero;
        //    Cep = cep;
        //    Bairro = bairro;
        //    Cidade = cidade;
        //    Estado = estado;
        //    Complemento = complemento;
        //    PontoReferencia = pontoReferencia;
        //}

    }
}

