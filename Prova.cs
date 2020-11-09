using System;
using System.Collections.Generic;
using System.Linq;
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
        public string Prova4(double anoDeNascimento)
        //Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade. 
        //Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente.
        {
            if (anoDeNascimento > 2002)
            {
                return "Menor de idade";
            }
            else
            {
                return "Maior de idade";
            }
        }
        public List<double> Prova5(List<string> numbers)
        //Solicite ao usuário que informe 5 números e armazene em um array. Toda vez que o usuário digitar um valor inválido, 
        //a aplicação deverá armazenas “null” no índice correspondente. Ao final, imprimir apenas os números válidos.
        {
            var numeros = new List<double>();

            foreach (var item in numbers)
            {
                try
                {
                    var verificacao = double.Parse(item);
                    numeros.Add(verificacao);
                }
                
                catch (System.Exception)
                {    
                //    var index = numbers.IndexOf(item);
                //    numbers[index] = null;
                }
            }
            
            return numeros;
        }
        public double Prova6(List<double> salarios)
        //Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. 
        //A aplicação será encerrada quando o usuário digitar a palavra "calcular". 
        //Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente.
        {
            var totalSalarios = new List<double>();
            // var soma = 0.0;
            
            for (int i = 0; i < salarios.Count; i++)
            {
                try
                {
                    if (salarios[i] > -1)
                    {
                        totalSalarios.Add(salarios[i]);
                    } 
                }
    
                catch (System.Exception)
                {

                }
            }

            // for (int i = 0; i < totalSalarios.Count; i++)
            // {
            //     soma += totalSalarios[i];
            // }

            // return (double)soma / totalSalarios.Count();

            return totalSalarios.Sum() / totalSalarios.Count;
        }

        public string Prova7(List<String> ufUsers)
        //Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. 
        //A aplicação deverá mostrar uma lista com todas as opções para o usuário, 
        //e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF.
        //Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina.
        {
            var count = 0.0;

            // for (int i = 0; i < ufUsers.Count; i++)
            // {
            //     if (ufUsers[i] == "42")
            //     {
            //         count += 1;
            //     }
            // }
            count = ufUsers.Where(item => item == "42").Count();

            return $"{(count * 100) / ufUsers.Count}%";
        }
        
        public List<string> Prova8(List<string> matutino, List<string> vespertino)
        //Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. Cada turma possui 5 alunos. 
        //Armazene os nomes em dois arrays distintos de forma alternada, ou seja, o primeiro nome deve ser armazenado no array da Matutino, 
        //o segundo nome deve ser armazenado no array da Turma Vespertino, assim por diante. 
        //Ao final imprima apenas os nomes dos alunos que estão estudando em período integral. 
        //Caso nenhum aluno esteja cadastrado em ambas as turmas, imprimir a mensagem “Todos os alunos estudam em meio período”.
        {
            var alunoIntegral = new List<string>();

            foreach (var item in matutino)
            {
                for (int i = 0; i < vespertino.Count; i++)
                {
                    if (item == vespertino[i])
                    {
                        alunoIntegral.Add(item);            
                    }
                }
            }
            
            if (alunoIntegral.Count == 0)
            {
                alunoIntegral.Add("Todos os alunos estudam em meio período");
            }

            return alunoIntegral;
        }
    }
}