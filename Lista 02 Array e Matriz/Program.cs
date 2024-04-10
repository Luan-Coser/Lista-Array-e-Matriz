
int [] vetor = new int [5];


for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Vetor:" + i);
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < vetor.Length; j++)
{
    Console.WriteLine("Vetor:" + vetor[j]);
}