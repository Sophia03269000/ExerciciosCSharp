string nome;
int valor, valorpg, total;
Console.WriteLine("Digite o valor da compra: ");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor pago: ");
valorpg = int.Parse(Console.ReadLine());

total = valorpg - valor;

Console.WriteLine("O valor da compra é: " + valor);
Console.WriteLine("O valor do troco é: " + total);

if (total > 99)
{
    Console.WriteLine("O troco será com nota de 100");
}
if (total >= 10 && total < 100)
{
    Console.WriteLine("O troco será com nota de 10");
}
if (total < 10)
{
    Console.WriteLine("O troco será com nota de 1");
}