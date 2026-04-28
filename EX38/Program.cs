// See https:// 
string nome;
float nota1, nota2, nota3;
Console.WriteLine("Digite o numero A: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero B: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero C: ");
nota3 = float.Parse(Console.ReadLine());

if (nota1 + nota2 >= nota3)
{
    Console.WriteLine("A soma de A + B é maior que C.");
}
if (nota1 + nota2 >= nota3)
{
    Console.WriteLine("A soma de A + B é menor que C.");
}
if (nota1 + nota2 >= nota3)
{
    Console.WriteLine("A soma de A + B é igual que C.");
}
