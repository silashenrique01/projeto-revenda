using System.Collections.Generic;
using Domain;
using Domain.Helpers;
using NUnit.Framework;

namespace Tests.Domain
{
    public class Tests
    {
        [Test]
        public void Setup()
        {

            var contato = new Contato("Nome", "Sobrenome", true);
            var telefone = new Telefone("999999999");
            var telefones = new List<Telefone>();
            telefones.Add(telefone);
            var endereco = new Endereco("rua", 123, "04166003", "bairro", "s�o paulo", "sp", "complemento", "ponto de referencia");
            var enderecos = new List<Endereco>();
            enderecos.Add(endereco);
            var contatos = new List<Contato>();
            contatos.Add(contato);
            var revenda = new Revenda("12345678000195", "Raz�o Social", "Nome Fantasia", "contato@email.com", telefones, contatos, enderecos, null);

        }

        public void DeveCriarRevenda_QuandoCnpjValido(Revenda revenda)
        {

            var validarCnpj = new CNPJ(revenda.Cnpj);
            var teste = validarCnpj.Validar();

            Assert.IsNotNull(validarCnpj);
            Assert.IsTrue(teste);
        }

        public void DeveCriarRevenda_QuandoCnpjObrigatorio(Revenda revenda)
        {

            Assert.IsNotNull(validarCnpj);
            Assert.IsTrue(teste);
        }
    }
}