using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] argumentos)
        { 

            const string constante = "uma constante que não muda";
                // teste os argumentos e se ele foi vazio, não roda, pois precisa de inteiro       
            if(argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar número inteiro");
                return; // para aqui
            }

            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro); //variavel booleana v ou f
               // pega primeira posição 
            //tenta converter algo para inteiro e salvar na variável inteiro

            if(teste == false)
            {
                Console.WriteLine("O argumento informado não é inteiro");
                return; // para aqui
            }
            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }

    }
}