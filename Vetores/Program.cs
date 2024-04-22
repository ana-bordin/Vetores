// programa que lê vetor com 5 números inteiro;

int numero;
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    numero = int.Parse(Console.ReadLine());
    numeros[i] = numero;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numeros[i]);
}