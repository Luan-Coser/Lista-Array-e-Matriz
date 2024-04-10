//Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

int[,] matriz = new int [3,3];

for  (int i = 0; i < matriz.GetLength(0); i++ )
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine($"Valor da matriz ({i},{j})");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}



for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine($"Valor da matriz ({i},{j}):{matriz[i,j]}");
    }
}