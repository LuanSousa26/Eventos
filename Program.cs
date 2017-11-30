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

        //Evento criado do tipo Delegate  
        static event Calculo Calc;


        /*
       **************************************MÉTODOS****************************************************************
              */

        //Método Crescente(), observa-se que ele também é void igual ao delegate
        public static void Crescente()
        {
            for (int i = 1; i <= 100; i++)
                System.Console.WriteLine(i);
        }

        //Método Decrescente(), observa-se que ele também é void igual ao delegate
        public static void Decrescente()
        {
            for (int i = 100; i >= 1; i--)
                System.Console.WriteLine(i);
        }

        //Método Calculadora(), observa-se que ele também é void igual ao delegate
        public static void Calculadora()
        {



            int Numero1, Numero2, Total;
        // Estrutura de controle, se houver algum erro na leitura do número, colocar null ou um caracter o sistema retorna para o Primeiro:
        Primeiro:
            System.Console.WriteLine(" Favor Digite o primeiro número:");
            try
            {
                Numero1 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("O número não está no padrão correto!");
                //Vá para Primeiro:, ou seja, faz tudo denovo até o try passar com um número inteiro
                goto Primeiro;
            }
        // Estrutura de controle, se houver algum erro na leitura do número, colocar null ou um caracter o sistema retorna para o Segundo:
        Segundo:

            try
            {
                //Solicita e lê os dados
                System.Console.WriteLine("Favor digite o segundo número:");
                Numero2 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("O número não está no Padrão correto!");
                //Vá para Segundo:, ou seja, faz tudo denovo até o TRY passar com um número inteiro.
                goto Segundo;
            }
        //Se entrar alguma operação não aceita, retornará para o Operação fará novamente a solicitação.
        Operacao:
            System.Console.WriteLine("Favor digite a Operação Desejada: + * / -");
            String opcao = Console.ReadLine();
            switch (opcao)
            {
                //Soma
                case "+":
                    Total = Numero1 + Numero2;
                    break;
                //Multiplicação
                case "*":
                    Total = Numero1 * Numero2;
                    break;
                //Divisão
                case "/":
                    Total = Numero1 / Numero2;
                    break;
                //Subtração
                case "-":
                    Total = Numero1 - Numero2;
                    break;
                //Caso não aceito
                default:
                    System.Console.WriteLine("Opção incorreta!");
                //Se a operação for errada volta para o Operacao: Solicitando novamente para escolher
                // uma opção.
                    goto Operacao;


            }

            //Apresenta no console os dados do cálculo.
            Console.WriteLine(" Calculo :" + Numero1 + opcao + Numero2 + "=" + Total);

        }



    }
}
