using System;
using System.Text;

namespace FirstTest
{
    class Program
    {
        static void question1()
        {
            //Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia 
            //e qual o valor/hora de seu serviço. Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado. 
            //A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula. 
            
            double timework, hourvalue, valuedaywork;
            Console.WriteLine("informe quantas horas e minutos trabalha por dia (ex.: 8,5 para oito horas e meia): ");
            timework = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe qual o valor da sua hora trabalhada: (ex: 15,00)");
            hourvalue = Convert.ToDouble(Console.ReadLine());
            valuedaywork = timework*hourvalue;
            Console.WriteLine("O valor recebido por dia de trabalho é de: \n {0,15:c}", valuedaywork);
        }

        static void question2()
        {
            //Solicite ao usuário que informe uma palavra qualquer, porém ele deve digitar uma letra por vez. 
            //Quando o usuário informar a palavra “Finalizar”, a aplicação deve apresentar a palavra inteira.
            Console.WriteLine ("Informe uma palavra qualquer, porém digite uma letra por vez seguido de enter. Informe “Finalizar”, para exibir a palavra inteira.");
            var word = "";
            while (true)
            {
                Console.WriteLine("Digite uma letra");
                var letter = Console.ReadLine();
                if (letter == "Finalizar")
                {
                    break;
                }
                word += letter;
            }
            Console.WriteLine($"A palavra é: {word}");
        }

        static void question3()
        {
            //Solicite para 5 usuários que informem seus nomes e se são solteiros. 
            //Ao final apresente o nome de todos os usuários solteiros.
            
            var singleMen = new StringBuilder();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("informe seu nome: ");
                string name= (Console.ReadLine());
                Console.WriteLine("Você é solteiro? respoda y para sim ou n para não ");
                string condition= (Console.ReadLine());
                if (condition == "y")
                {
                    singleMen.Append($"{name}, ");
                }
            }

            singleMen.Remove(singleMen.Length - 2, 2);
            Console.WriteLine($"Todos os solteiros: {singleMen}");
               
        }

        static void question4()
        {
            //Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade. 
            //Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente.
            
            var input = 0;

            Console.WriteLine("Em que ano você nasceu?");
            while (true)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Ano inválido! Informe novamente");
                }
            }

            if (input <= 2002)
            {
               Console.WriteLine("Você é maior de idade!"); 
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }
        }
        
        static void question5()
        {
            //Solicite ao usuário que informe 5 números e armazene em um array. 
            //Toda vez que o usuário digitar um valor inválido, a aplicação deverá armazenas “null” 
            //no índice correspondente. Ao final, imprimir apenas os números válidos.
            
            var numbers = new double?[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Informe um número:");
                try
                {
                    numbers[i] = Double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {}
            }

            System.Console.WriteLine("Números válidos:");
            foreach (var number in numbers)
            {
                if (number != null)
                {
                    System.Console.WriteLine(number);
                }
            }
        }
        static void question6()
        {
            //Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. 
            //A aplicação será encerrada quando o usuário digitar a palavra "calcular". 
            //Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente.
            
            var answers = 0;
            var sum = 0.0;
            while (true)
            {
                System.Console.WriteLine("Digite seu salário");
                var input = Console.ReadLine();

                if (input == "calcular")
                {
                    break;
                }

                var salary = Double.Parse(input);
                if (salary < 0)
                {
                    continue;
                }

                answers++;
                sum += Double.Parse (input);
            }

            System.Console.WriteLine($"A média salarial é: R${(sum / answers).ToString("0.00")}");
        }

        static void question7()
        {
            //Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. 
            //A aplicação deverá mostrar uma lista com todas as opções para o usuário, 
            //e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. 
            //Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina.
            
            (int id, string UF) scUF = (42, "SC");
            var UFs = new (int id, string UF)[27]
            {
            scUF,
                    
                (11, "RO"),
                (12, "AC"),
                (13, "AM"),
                (14, "RR"),
                (15, "PA"),
                (16, "AP"),
                (17, "TO"),
                (21, "MA"),
                (22, "PI"),
                (23, "CE"),
                (24, "RN"),
                (25, "PB"),
                (26, "PE"),
                (27, "AL"),
                (28, "SE"),
                (29, "BA"),
                (31, "MG"),
                (32, "ES"),
                (33, "RJ"),
                (35, "SP"),
                (41, "PR"),
                (43, "RS"),
                (50, "MS"),
                (51, "MT"),
                (52, "GO"),
                (53, "DF")
            };
            System.Console.WriteLine("Lista de UFs");

            foreach (var item in UFs)
            {                
                System.Console.WriteLine($"{item.id} - {item.UF}");   
            }

            var bornInSC = 0;
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Digite o ID da UF que representa o estado onde você nasceu");
                var input = Int32.Parse(Console.ReadLine());
                if (input == scUF.id)
                {
                    bornInSC++;
                }
            }

            System.Console.WriteLine("Porcentagem de usuários nascidos em SC:");
            System.Console.WriteLine((bornInSC * 100) / 5);
        }

        static void question8()
        {
            //Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. 
            //Cada turma possui 5 alunos. Armazene os nomes em dois arrays distintos de forma alternada, 
            //ou seja, o primeiro nome deve ser armazenado no array da Matutino, 
            //o segundo nome deve ser armazenado no array da Turma Vespertino, assim por diante. 
            //Ao final imprima apenas os nomes dos alunos que estão estudando em período integral. 
            //Caso nenhum aluno esteja cadastrado em ambas as turmas, imprimir a mensagem 
            //“todos os alunos estudam em meio período”.
            
            var studentsPerClass = 5;
            var morningClass = new string[studentsPerClass];
            var afternoonClass = new string[studentsPerClass];
            
            for (int i = 0; i < studentsPerClass; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine("Digite um nome");
                    var input = Console.ReadLine();
                    
                    var currentClass = j == 0 ? morningClass : afternoonClass;
                    currentClass[i] = input;
                }
            }

            var onlyHalfPeriodStudents = true;

            System.Console.WriteLine("Pesquisando por alunos de período integral...");
            foreach (var morningStudent in morningClass)
            {
                foreach (var afternoonStudent in afternoonClass)
                {
                    if (morningStudent == afternoonStudent)
                    {
                        System.Console.WriteLine(morningStudent);
                        onlyHalfPeriodStudents = false;
                    }
                }
            }

            if (onlyHalfPeriodStudents)
            {
                System.Console.WriteLine("todos os alunos estudam em meio período");
            }
        }
        static void Main(string[] args)=>question1();
    
    }
}
