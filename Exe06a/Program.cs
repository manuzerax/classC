// Criar uma variavel ouum vetor 
// Criar um laço para percorrer o vetor 
// Para cada posição gerar um valor aleatorio 
// Organizar o vetor BUBBLE SORT


int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);
}

// Imprimir o vetor sem ordenação
Console.WriteLine("Vetor antes da ordenação:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(" " + vetor[i] + " ");
}
Console.WriteLine();

// Ordenar o vetor em ordem crescente

for (int i = 0; i < vetor.Length - 1; i++)
{
    if (vetor[i] > vetor[i + 1])
    {

        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
         }
}

// Imprimir o vetor após a ordenação
Console.WriteLine("Vetor após a ordenação:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(" " + vetor[i] + " ");
}
Console.WriteLine();
