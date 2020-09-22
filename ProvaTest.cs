using System.Collections.Generic;
using Xunit;

namespace Prova
{
    public class ProvaTest
    {
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