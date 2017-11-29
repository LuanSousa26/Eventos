using System;

namespace Eventos
{
    /*
        Author: Luan Sousa


        Está sendo utilizado no código o Delegate Tipo Void que possui o evento Calc
        Este evento antes de ser executado inclui 3 métodos por meio do delegate na
     sua lista de chamada e ao rodar o código ele os chama.
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia o evento com um novo delegate do tipo calculo e adiciona o método Crescente.
            Calc += new Calculo(Crescente);
            // Instancia o evento com um novo delegate do tipo calculo e adiciona o método Decrescente.
            Calc += new Calculo(Decrescente);
            // Instancia o evento com um novo delegate do tipo calculo e adiciona o método Decrescente.
            Calc += new Calculo(Calculadora);
            // Chamada do Evento, nesta linha os três métodos inseridos acima serão chamados em ordem.
            Calc();


        }
        // criando o delegate do tipo void, os métodos a serem inseridos em um delegate devem obedecer sua estrutura, ou seja o delegate aceita métodos VOID.
        public delegate void Calculo();

        static event Calculo Calc;

        public static void Crescente()
        {
            for (int i = 1; i <= 100; i++)
                System.Console.WriteLine(i);
        }


        public static void Decrescente()
        {
            for (int i = 100; i >= 1; i--)
                System.Console.WriteLine(i);
        }

        public static void Calculadora()
        {



            int Numero1, Numero2, Total;

        Primeiro:
            System.Console.WriteLine(" Favor Digite o primeiro número:");
            try
            {
                Numero1 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("O número não está no Padrão correto!");
                goto Primeiro;
            }

        Segundo:

            try
            {
                System.Console.WriteLine("Favor digite o segundo número:");
                Numero2 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("O número não está no Padrão correto!");
                goto Segundo;
            }

        Operacao:
            System.Console.WriteLine("Favor digite a Operação Desejada: + * / -");
            String opcao = Console.ReadLine();
            switch (opcao)
            {

                case "+":
                    Total = Numero1 + Numero2;
                    break;

                case "*":
                    Total = Numero1 * Numero2;
                    break;

                case "/":
                    Total = Numero1 / Numero2;
                    break;

                case "-":
                    Total = Numero1 - Numero2;
                    break;

                default:
                    System.Console.WriteLine("Opção incorreta!");
                    goto Operacao;


            }
            Console.WriteLine(" Calculo :" + Numero1 + opcao + Numero2 + "=" + Total);

        }



    }
}
