
//busca linear em vetor nao ordenado
int i = 1;
int bl = -1;
int x = 3; //declaracao do item buscado

int[] numeros = { 5, 3, 8, 1, 2 };

while (i < numeros.Length)
{
    if (numeros[i] == x)
    {
        bl = i;
        i = numeros.Length + 1; //saindo do loop
        Console.WriteLine($"Elemento encontrado no índice {bl}");
    } else
    {
        i++; //busca continua
    }
}
