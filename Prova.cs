using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    public class Prova
    {
        public string Prova1()
        // 1- Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia e qual o valor/hora de seu serviço. Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado. A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.
        {
            const int minutosEmHoras = 60;
            const int horasNumDia
        }
        public string Prova2(List<string> letras)
        //2- Solicite ao usuário que informe uma palavra qualquer, porém ele deve digitar uma letra por vez. Quando o usuário informar a palavra “Finalizar”, a aplicação deve apresentar a palavra inteira.
        {
            var palavra = new StringBuilder();

            foreach (var item in letras)
            {
                palavra.Append(item);
            }


            return palavra.ToString();

            // return String.Join("", letras);
        }
    }
}