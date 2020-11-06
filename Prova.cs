using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    public class Prova
    {
        public double Prova1(double minutesWorked, double hoursWorked, double hourPrice)
        //Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia e qual o valor/hora de seu serviço.
        //Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado. 
        //A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.
        {
            const int minutesInHours = 60;

            var minutesPrice = hourPrice / minutesInHours;
            var totalWorked = minutesWorked + (hoursWorked * minutesInHours);
            return minutesPrice * totalWorked;
        }
        public string Prova2(List<string> letras)
        //2- Solicite ao usuário que informe uma palavra qualquer, porém ele deve digitar uma letra por vez. 
        //Quando o usuário informar a palavra “Finalizar”, a aplicação deve apresentar a palavra inteira.
        {
            var palavra = "";
            
            foreach (var item in letras)
            {
                if (item == "Finalizar")
                {
                    return palavra;
                }
                
                palavra += item;
            }

            return palavra;

            // var palavra = new StringBuilder();

            // foreach (var item in letras)
            // {
            //     palavra.Append(item);
            // }


            // return palavra.ToString();

            // return String.Join("", letras);
        }
        public List<string> Prova3(List<string> nomes, List<string> solteirosOuCasados)
        // Solicite para 5 usuários que informem seus nomes e se são solteiros. 
        // Ao final apresente o nome de todos os usuários solteiros.
        {
            var solteiros = new List<string>();

            for (int i = 0; i < nomes.Count; i++)
            {
                if (solteirosOuCasados[i] == "Solteiro")
                {
                    solteiros.Add(nomes[i]);
                }
            }

            return solteiros;
        }
    }
}