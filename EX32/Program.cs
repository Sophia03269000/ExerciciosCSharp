// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

string nome;
float nota1, nota2, total;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a sua nota1: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua nota2: ");
nota2 = float.Parse(Console.ReadLine());
total = nota1 + nota2;

if (total >= 60)
{
    Console.WriteLine("Aluno: " + nome + " -- Aprovado");
}

else
{
    Console.WriteLine("Aluno: " + nome + " -- Reprovado");
}