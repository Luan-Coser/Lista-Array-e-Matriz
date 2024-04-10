// Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.

Random random = new Random();
int numeroAleatorio = random.Next(0, 100000);
int resultado = 0;

int[,] matriz1 = new int[4, 4];

    for (int i = 0; i < matriz1.GetLength(0); i++)
    {
        for (int j = 0; j < matriz1.GetLength(1); j++)
        {
            matriz1[i, j] = numeroAleatorio;
        }
    }


for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        if (resultado <= matriz1[i,j])
        {
            resultado = matriz1[i, j];
        }
    }
}

Console.WriteLine(resultado);