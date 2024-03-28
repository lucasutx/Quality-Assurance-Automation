using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Testes teste1 = new Testes("example@email.com","dsadsadsa");
        Testes teste2 = new Testes("example@email.com","odsadsadsa");

        try
        {
            
            teste1.ExisteCaracteresEspeciais();
            teste1.Tamanho();
            teste2.ExisteConta();
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("Erro: " + ex.Message);

        }
    }
}
