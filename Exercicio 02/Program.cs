// Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.

int[] vetor = new int[5];
int resultado = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Vetor:" + i);
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < vetor.Length; j++)
{
  if (resultado <= vetor[j])
    {
        resultado = vetor[j];
    }
}
Console.WriteLine("Maior vetor:"+resultado);
