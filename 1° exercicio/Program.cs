Console.WriteLine($"Informe o ano atual ex 2023 ");
int anoAtual = int.Parse(Console.ReadLine());
Console.WriteLine($"Informe o seu ano de nascimento");
int anoNascimento = int.Parse(Console.ReadLine());

int resposta = anoNascimento - anoAtual;

 if(resposta >= 16)
 {
    Console.WriteLine($"Pode votar");
    
}

else
{
    Console.WriteLine($"Não pode votar!");
    
}


