string nome;
double parafusos, parafusosprec, parafusosprec2;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite o número de parafusos: ");
parafusos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço dos parafusos: ");
parafusosprec = int.Parse(Console.ReadLine());
parafusosprec2 = (parafusosprec * 0.7) * parafusos;
double porcas, porcasprec, porcasprec2;
Console.WriteLine("Digite o número de porcas: ");
porcas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço das porcas: ");
porcasprec = int.Parse(Console.ReadLine());
porcasprec2 = (porcasprec * 0.9) * porcas;
double arruelas, arruelasprec, arruelasprec2;
Console.WriteLine("Digite o número de arruelas: ");
arruelas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço das arruelas: ");
arruelasprec = int.Parse(Console.ReadLine());
arruelasprec2 = (arruelasprec * 0.9) * arruelas;
if (parafusos > 0)
{
    Console.WriteLine(nome + " ao comprar " + parafusos + " parafusos voce tem 30% de desconto, que fica: " + parafusosprec2);
}
if (porcas > 0)
{
    Console.WriteLine(nome + " ao comprar " + porcas + " porcas voce tem 10% de desconto, que fica: " + porcasprec2);
}
if (arruelas > 0)
{
    Console.WriteLine(nome + " ao comprar " + arruelas + " arruelas voce tem 20% de desconto, que fica: " + arruelasprec2);
}
