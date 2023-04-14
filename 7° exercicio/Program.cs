int[] numeros = new int [15];

for(var i = 0; i <= 14 ;i++)
{
 Console.WriteLine($"Digite o {i + 1}° número");
 numeros[i] = int.Parse(Console.ReadLine());
 
}

Console.WriteLine($"Números registrados");

Console.WriteLine($"Numeros em ordem inversa");


for( var i = 14; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
    
}

 