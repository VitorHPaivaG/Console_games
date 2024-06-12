

//strings são imutaveis, por isso é colocado em um array de chars, e ai no caso
//qualquer operação que parece mudar uma string, na verdade está criando uma
//nova

namespace ConsoleGames
{
    internal class ReversedText
    {
        public void ReversedTextGame()
        {
            Console.Write("enter a word: ");
            string userword = Console.ReadLine();

            char[] chars = userword.ToCharArray();

            Array.Reverse(chars);

            string reversedUserWord = new string(chars);//string é por padrão uma classe, faz sentido

            Console.WriteLine("The original word: {0}", userword);
            Console.Write("The reversed word: {0}", reversedUserWord);

            Console.WriteLine("");

            Console.WriteLine("--Game still in progress, this is a WIP--");

            Console.WriteLine("Press any key to close the terminal");
            Console.ReadKey();
        }
    }
}