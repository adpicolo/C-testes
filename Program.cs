// See https://aka.ms/new-console-template for more information

//Ler um numero inteiro, um caractere, um numero double e 
//ler um nome, sexo, idade e altura na mesma linha
//armazenando-os em quatro variaveis com os devidos tipos.

int n1 = int.Parse(Console.ReadLine());//int.Parse converte string em numeros inteiros;
char ch = char.Parse(Console.ReadLine()); // converter string para char será char.Parse; 
double n2 = double.Parse(Console.ReadLine()); //para converter é double.parse; Tem que digitar o numero com virgula e nãoponto ex 4,32; 


string[] vet = Console.ReadLine().Split(' '); //para ser vetror sempre usar [] após o string.
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3]);



Console.WriteLine("você digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2);
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura);


