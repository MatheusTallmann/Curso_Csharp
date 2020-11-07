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
        [InlineData(new string[7]{"M","a","t","h","e","u","s"}, "Matheus")]
        [InlineData(new string[1]{"Finalizar"}, "")]
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
        [InlineData(new string[5]{"João","Silmar","Rodrigo","Vinicius","Matheus"}, new string[5]{"Casado","Casado","Casado","Solteiro","Solteiro"}, 
        new string[2]{"Vinicius", "Matheus"})]
        public void question_three(string[] nomes, string[] solteirosOuCasados, string[] expected)
        //Solicite para 5 usuários que informem seus nomes e se são solteiros. Ao final apresente o nome de todos os usuários solteiros.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var returnedValue = exercises.Prova3(nomes.ToList(), solteirosOuCasados.ToList());

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }
        [Theory]
        [InlineData(2004, "Menor de idade")]
        [InlineData(2000, "Maior de idade")]
        public void question_four(double anoDeNascimento, string expected)
        //Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade. 
        //Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var returnedValue = exercises.Prova4(anoDeNascimento);

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new string[5]{"1","2","3","4","5"}, new double[5]{1,2,3,4,5})]
        [InlineData(new string[5]{"1","f","3","4","5"}, new double[4]{1,3,4,5})]
        public void question_five(string[] numbers, double[] expected)
        //Solicite ao usuário que informe 5 números e armazene em um array. Toda vez que o usuário digitar um valor inválido, 
        //a aplicação deverá armazenas “null” no índice correspondente. Ao final, imprimir apenas os números válidos.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var returnedValue = exercises.Prova5(numbers.ToList());

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new double[5]{1000,1000,1000,1000,1000}, 1000)]
        public void question_six(double[] salario, double expected)
        //Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. 
        //A aplicação será encerrada quando o usuário digitar a palavra "calcular". 
        //Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente.
        {
            // Dado / Setup
            var exercises = new Prova();
            
            // Quando / Ação
            var returnedValue = exercises.Prova6(salario.ToList());

            //Deve / Asserção
            Assert.Equal(expected, returnedValue);
        }
    }
}