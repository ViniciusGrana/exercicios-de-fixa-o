Console.WriteLine(@$"Qual sera o combustivel? 
g(gasolina) R$5.30/litro
a(alcool) R$4.90/litro");
string combustivel = Console.ReadLine();
 
Console.WriteLine($"Quantos litros?");
float quantidade = float.Parse(Console.ReadLine());

if (combustivel == "a" && quantidade <= 20)
{
    Console.WriteLine($"O valor é R${quantidade* 4.9 * 0.97}");
    
}
else if (combustivel == "a" && quantidade >= 20)
{
Console.WriteLine($"O valor é R${quantidade * 4.9 * 0.95}");
}

if (combustivel == "g" && quantidade <= 20 )
{
    Console.WriteLine($"O valor é R${quantidade* 5.3 * 0.96}");
}
else if (combustivel == "g" && quantidade >= 20 )
{
    Console.WriteLine($"O valor é R${quantidade* 5.3 * 0.94}");
}

