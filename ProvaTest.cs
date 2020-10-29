using System.Collections.Generic;
using Xunit;

namespace Prova
{
    public class ProvaTest
    {
        [Theory]
        [InlineData]
        public void deve_retornar_o_total_de_dinheiro_que_o_usuario_ganha_num_dia_trabalhando()
        {
            var letras = new List<string>{"c", "e"};
            letras.Add("l");

            var prova = new Prova();
            var palavra = prova.Prova1(letras);

            Assert.Equal("cel", palavra);
        }
        [Fact]
        public void deve_retornar_cel_quando_informado_c_e_l()
        {
            var letras = new List<string>{"c", "e"};
            letras.Add("l");

            var prova = new Prova();
            var palavra = prova.Prova2(letras);

            Assert.Equal("cel", palavra);
        }

    }
}