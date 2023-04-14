Console.WriteLine(@$"Qual produto voce deseja?
Produtos disponiveis:
s (sabao em pó)  Preço unitario R$12.90 ");
string produtoDesejado = Console.ReadLine();

Console.WriteLine($"Quantidade");
float quantidade = float.Parse(Console.ReadLine());

    if(quantidade<=5)
    {
        Console.WriteLine($"Estamos com um Desconto de 2%");
        Console.WriteLine($"Sua compra deu R${quantidade * 12.90 * 0.98}");
        
        
    }
    else if(quantidade >5 && quantidade <=10)
    {
        Console.WriteLine($"Estamos com um Desconto de 3%");
        Console.WriteLine($"Sua compra deu R${quantidade * 12.90 * 0.97}");
        
        
    }

    else
    {
        Console.WriteLine($"Estamos com um Desconto de 5%");
        Console.WriteLine($"Sua compra deu R${quantidade * 12.90 * 0.95}");
    }

