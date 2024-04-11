//Busca de Dados em uma Matriz de Animais Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um
//animal:Nome Espécie Idade Peso Escreva um programa em C# que permita ao usuário buscar animais por uma determinada
//propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca
string[,] animais =
{
    { "Fido", "Cachorro", "5", "10kg" },
    { "Whiskers", "Gato", "5", "5kg" },
    { "Buddy", "Cachorro", "3", "8kg" },
    { "Fluffy", "Gato", "2", "4kg" },
    { "Spot", "Cachorro", "4", "12kg" }
};

string pesquisa;


Console.WriteLine("Escreva:");
pesquisa = Console.ReadLine();

bool encontrado = false;

for (int i = 0; i < animais.GetLength(0); i++)
{
    for (int j = 0; j < animais.GetLength(1); j++)
    {
        if (animais[i, j].Equals(pesquisa, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Nome: {animais[i, 0]}, Espécie: {animais[i, 1]}, Idade: {animais[i, 2]}, Peso: {animais[i, 3]}");
            encontrado = true;
            break; 
        }
    }
}

if (!encontrado)
{
    Console.WriteLine("Nenhum animal foi encontrado");
}