using System;


namespace ContadorDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, meio, fim, tamTitulo, meioTitulo, posicaoFinalTitulo, cw = 19, posicaocw;
            string titulo;

            Sep1();
            Console.WriteLine("                Contador de caracteres");
            Sep2();

            Console.Write("Posição do caractere de início do separador: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Posição do caractere final do separador: ");
            fim = int.Parse(Console.ReadLine());

            Console.Write("Texto a ser inserido: ");
            titulo = Console.ReadLine();

            Console.Write("Informe a posição inicial da declaração CW: ");
            posicaocw = int.Parse(Console.ReadLine());

            meio = (fim - inicio) / 2;
            tamTitulo = titulo.Length;
            meioTitulo = tamTitulo / 2;
            posicaoFinalTitulo = (meio-meioTitulo)+(posicaocw+cw);

            Console.WriteLine($"\nPosicionar o início do texto no caractere: {posicaoFinalTitulo}\n");

            Sep2();
            Console.WriteLine("          LLPDigital - V1.0 - Beta - 03/2021");
            Sep1();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar.");
            Console.ReadKey();
        }

        static void Sep1()
        {
            Console.WriteLine("=======================================================");
        }

        static void Sep2()
        {
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
