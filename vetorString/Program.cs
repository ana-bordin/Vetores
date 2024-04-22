// programa que lê vetor com 5 letras;

char[] palavra = new char[10];

for (int i = 0; i < 10; i++)
{
    palavra[i] = char.Parse(Console.ReadLine());
    //pode ser Console.readKey também;
}

for (int i = 0; i < 10; i++)
{
    Console.Write(palavra[i]);
}

Console.WriteLine();

int x = 9;
while (x >= 0)
{
    Console.Write(palavra[x]);
    x--;
}

Console.WriteLine();

for  (int i = 1; i < 10; i += 2)
{
    Console.Write(palavra[i]);
}