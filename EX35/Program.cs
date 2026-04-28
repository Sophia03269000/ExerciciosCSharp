string nome;
float nota1, nota2, nota3;
Console.WriteLine("Digite o nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a nota de Biologia: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de Matematica: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota de Conceitos Gerais: ");
nota3 = float.Parse(Console.ReadLine());

if (nota1 >= 7 && nota2 >= 7 && nota3 >= 7){
    Console.WriteLine(nome + " aluno Aprovado!");
}

