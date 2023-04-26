using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa? ");
int quarto = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double produto = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha) ");    
string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
int idade  = int.Parse(vet[1]);
double altura  = double.Parse(vet[2]);

Console.WriteLine(nomeCompleto);
Console.WriteLine(quarto);
Console.WriteLine(produto);
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(altura);