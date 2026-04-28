string nome;
float nota1, nota2, nota3, total;
Console.WriteLine("Digite a nota1: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota2: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota3: ");
nota3 = float.Parse(Console.ReadLine());

total = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("A média é: " + total);