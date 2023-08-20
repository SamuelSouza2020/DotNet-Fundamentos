
using System;
using DotNet_Fundamentos.Models;

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É vogal");
        break;
    default:
        Console.WriteLine("Não é vogal");
        break;
}



// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);



// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Reju";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();

// Pessoa pessoaFisica = new Pessoa();