using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Prova
{
    public class ProvaTest
    {
        [Theory]
        [InlineData(30, 8, 20, 170)]
        [InlineData(30, 8, 60, 510)]
        public void question_one(double minutesWorked, double hoursWorked, double hourPrice, double expected)
        //Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia e qual o valor/hora de seu serviço.
        //Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado. 
        //A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var returnedValue = exercises.Prova1(minutesWorked, hoursWorked, hourPrice);

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }
        
        [Theory]
        [InlineData(new string[3]{"c","e","l"}, "cel")]
        public void question_two(string[] letras, string expected)
        {
            // Dado / Setup
            var prova = new Prova();

            // Quando / Ação
            var returnedValue = prova.Prova2(letras.ToList());

            // Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }
        
        [Theory]
        [InlineData(new string[5]{"João","Silmar","Rodrigo","Vinicius","Matheus"}, new string[3]{"João","Silmar","Rodrigo"}, new string[2]{"Vinicius","Matheus"}]
        public void question_three(string[] nomes, string[] casados, string[] solteiros)
        //Solicite para 5 usuários que informem seus nomes e se são solteiros. Ao final apresente o nome de todos os usuários solteiros.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var returnedValue = exercises.Prova3(nomes.ToList(), casados.ToList(), solteiros.ToList());

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }
    }
}