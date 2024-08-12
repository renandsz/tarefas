/*
int limite = 10;

for (int i = 0 ; i < limite ; i++){
    Console.WriteLine(i);
}


*/





/*


void Trocar(int[] array, int i, int j)
{
    int aux = array[i];
    array[i] = array[j];
    array[j] = aux;
}

void ImprimirBarras(int[] array){
    foreach(var numero in array){
        Console.WriteLine(String.Concat(Enumerable.Repeat("#", numero))+ "-" + numero);
    }
}
void Randomizar(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        int j = random.Next(0, array.Length);
        Trocar(array, i, j);
    }
}

// Função que ordena um array de inteiros usando bubble sort
void Ordenar(int[] array)
{
    // Variáveis auxiliares
    int i, j;
    int tam = array.Length;
    // Flag que indica se houve troca
    bool trocou;

    // Percorre o array n - 1 vezes
    for (i = 0; i < tam-1; i++)
    {
        // Inicializa a flag como false
        trocou = false;

        // Compara os elementos adjacentes
        for (j = 0; j < tam - i - 1; j++)
        {
            // Se o elemento atual for maior que o próximo
            if (array[j] > array[j + 1])
            {
                // Troca os elementos de posição
                Trocar(array, j, j+1);
                // Marca a flag como true
                trocou = true;
                Thread.Sleep(10);
                Console.Clear();
                ImprimirBarras(array);
            }
        }

        // Se não houve troca, o array está ordenado
        if (trocou == false)
            break;
    }
}



// programa

Console.Clear();
int[] principal = new int[40];

for (int i = 0; i < principal.Length; i++)
{
    principal[i] = i+1;
}




ImprimirBarras(principal);

Console.ReadKey();
Console.Clear();
Randomizar(principal);

ImprimirBarras(principal);

Console.ReadKey();
Console.Clear();
Ordenar(principal);
//////////////////////////////////////








int a = 42;
int b = 15;

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");


Console.WriteLine();
int aux = a;
a = b;
b = aux;
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 10)));
Console.WriteLine($"a = {a}, b = {b}");



int[] principal = new int[100];

for (int i = 0; i < principal.Length; i++)
{
    principal[i] = i+1;
}


void Trocar(int[] array, int i, int j)
{
    int aux = array[i];
    array[i] = array[j];
    array[j] = aux;
}

void Randomizar(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        int j = random.Next(0, array.Length);
        Trocar(array, i, j);
    }
}
Console.WriteLine(string.Join("-", principal));
Randomizar(principal);

Console.WriteLine(string.Join("-",principal));
Console.ReadKey();


*/