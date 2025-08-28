// Peça ao usuário que informe se está chovendo (responda 'sim' ou 'não'). 
//Se estiver chovendo, informe que deve levar guarda-chuva; 
//caso contrário, informe que não precisa.
internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Esta chovendo Hoje?");
        Console.WriteLine("Se sim, digite s");
        Console.WriteLine("Se nao, digite n");
        
        string resposta = Console.ReadLine();

        if (resposta == "s")
        {
            Console.WriteLine("Melhor Levar um guarda-chuva!");
        }
        else if (resposta == "n")
        {
            Console.WriteLine("Curta o dia, deixe o guarda-chuva em casa");
        }else
        {
            Console.WriteLine("Desculpe, nao entendi =(");
        }
    }
}