using System;

namespace hashing
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("hashing");
            
            // cria uma tabela hash
            TabelaHash tabela = new TabelaHash();
            tabela.Inserir("pedro", "marcado por atitudes impulsivas, como quando usou a espada para  defender seu mestre");
            tabela.Inserir("mateus", "era um coletor de impostos do povo hebreu, durante a dominacao romana");
            
            // busca e exibe alguns resultados
            Console.WriteLine("pedro => " + 
            tabela.GetValor("pedro"));
            Console.WriteLine("mateus => " + 
            tabela.GetValor("mateus"));
    }
}
}