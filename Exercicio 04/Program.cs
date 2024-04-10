// Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes
// de ambos os vetores, armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante.

int[,] matriz1 = new int[2, 2];
int[,] matriz2 = new int[2, 2];
int[,] matrizSoma = new int[2, 2];


matrizInicializar( matriz1);
matrizInicializar( matriz2);

static void matrizInicializar( int [,]matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine($"Valor da matriz ({i},{j})");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }
}


for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        matrizSoma[i,j] = matriz1[i,j] + matriz2[i,j];
    }
}

for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        Console.WriteLine($"Valor da matriz soma ({i},{j}) = " + matrizSoma[i,j]);
    }
}
