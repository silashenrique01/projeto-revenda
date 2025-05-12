using System;

namespace Domain
{
    public class Endereco
    {
        public Guid EnderecoId {  get; private set; }
        public string Longradouro { get; private set; }
        public int Numero {  get; private set; }
        public int Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public string Complemento { get; private set; }

        public string PontoReferencia { get; private set; }

        public Endereco(string longradouro, int numero, int cep, string bairro, string cidade, string estado, string complemento, string pontoReferencia)
        {
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

