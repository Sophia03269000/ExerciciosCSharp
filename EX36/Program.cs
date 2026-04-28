string nome;
float v1;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite o valor da venda: ");
v1 = float.Parse(Console.ReadLine());

if (v1 >= 50.000)
{
    Console.WriteLine(nome + " a sua comissão é de: 12% do valor vendido que foi: " + v1);
}
if (v1 >= 30.000 && v1 <= 50.000)
{
    Console.WriteLine(nome + " a sua comissão é de: 9.5%  do valor vendido que foi: " + v1);
}
if (v1 <= 30.000)
{
    Console.WriteLine(nome + " a sua comissão é de: 9.5%  do valor vendido que foi: " + v1);
}
