// See https://aka.ms/new-console-template for more information

string nome = Console.ReadLine();
int quarto = int.Parse(Console.ReadLine());
double preçoProduto = double.Parse(Console.ReadLine());

string[] vet= Console.ReadLine().Split(' ');
string ultimoNome = vet[0];
int idade = int.Parse(vet[1]);
double  altura = double.Parse(vet[2]);




Console.WriteLine("digitwe seu nome completo: " + nome);
Console.WriteLine("digite quantos quartos tem em sua casa: " + quarto);
Console.WriteLine("digite o preço do produto:" + preçoProduto);
Console.WriteLine("entre digitando seu ultimo nome, idade e altura: ");
Console.WriteLine(ultimoNome); 
Console.WriteLine(idade);
Console.WriteLine(altura);  



