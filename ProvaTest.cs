using System.Collections.Generic;
using Xunit;

namespace Prova
{
    public class ProvaTest
    {
        [Theory]
        [InlineData(30, 8, 20, 170)]
        [InlineData(30, 8, 60, 510)]
        public void should_return_the_total_money_received_in_a_day_worked(double minutesWorked, double hoursWorked, double hourPrice, double expected)
        //Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia e qual o valor/hora de seu serviço.
        //Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado. 
        //A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var expectedValue = exercises.Prova1(minutesWorked, hoursWorked, hourPrice);

            //Deve / Asserção
            Assert.Equal(expected, expectedValue);
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