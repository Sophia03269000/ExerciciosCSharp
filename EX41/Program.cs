string nome;
double numa, numb, minimo, comissao, final, porcvendas;
Console.WriteLine("Digite o nome do vendedor: ");
nome = Console.ReadLine();
Console.WriteLine("Digite o número de carros por mês: ");
numa = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de vendas por mês : ");
numb = float.Parse(Console.ReadLine());
minimo = 1600 * 2;
comissao = numa * 50;
porcvendas = numb * 0.05;
final = minimo + comissao + porcvendas;
Console.WriteLine("Salário fixo: " + minimo);
Console.WriteLine("Valor dos 5% das vendas: " + porcvendas);
Console.WriteLine("Valor em comissão: " + comissao);
Console.WriteLine("Salário total: " + final);

