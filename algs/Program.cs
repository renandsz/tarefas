
    
        Pag1();
    

    void Pag1()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao Mundo de Fantasia! Para começar sua jornada, escolha um companheiro para te acompanhar:");
        Console.WriteLine("1 - Dragão");
        Console.WriteLine("2 - Fada");
        Console.WriteLine("3 - Gigante");

        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            Pag2Dragao();
        }
        else if (escolha == 2)
        {
            Pag3Fada();
        }
        else if (escolha == 3)
        {
            Pag4Gigante();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }

    void Pag2Dragao()
    {
        Console.Clear();
        Console.WriteLine("Você escolheu o Dragão como seu companheiro! Vocês se deparam com um labirinto misterioso.");
        Console.WriteLine("Como vocês vão enfrentar o labirinto?");
        Console.WriteLine("1 - Voar sobre o labirinto");
        Console.WriteLine("2 - Queimar as paredes do labirinto");
        Console.WriteLine("3 - Pedir ajuda a outros seres mágicos");

        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1 || escolha == 2)
        {
            Pag5Derrota();
        }
        else if (escolha == 3)
        {
            Pag6Enigma();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }

    void Pag3Fada()
    {
        Console.Clear();
        Console.WriteLine("Você escolheu a Fada como sua companheira! Vocês encontram um rio encantado.");
        Console.WriteLine("Como vocês vão atravessar o rio?");
        Console.WriteLine("1 - Voar sobre o rio");
        Console.WriteLine("2 - Criar uma ponte mágica");
        Console.WriteLine("3 - Pedir ajuda aos peixes");

        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1 || escolha == 2)
        {
            Pag7Encontro();
        }
        else if (escolha == 3)
        {
            Pag5Derrota();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }

    void Pag4Gigante()
    {
        Console.Clear();
        Console.WriteLine("Você escolheu o Gigante como seu companheiro! Encontram um desfiladeiro profundo.");
        Console.WriteLine("Como vocês vão atravessar o desfiladeiro?");
        Console.WriteLine("1 - Pular sobre o desfiladeiro");
        Console.WriteLine("2 - Criar uma ponte com árvores");

        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            Pag5Derrota();
        }
        else if (escolha == 2)
        {
            Pag7Encontro();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }

    void Pag5Derrota()
    {
        Console.Clear();
        Console.WriteLine("Você falhou na sua missão! Seu companheiro e você foram capturados por um feitiço maligno.");
        Console.WriteLine("Fim da jornada!");
    }

    void Pag6Enigma()
    {
        Console.Clear();
        Console.WriteLine("Vocês encontram um ser misterioso que propõe um enigma para liberar o caminho.");
        Console.WriteLine("Qual é o enigma?");
        Console.WriteLine("1 + 1 = ?");
        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 2)
        {
            Pag8Vitoria();
        }
        else
        {
            Pag5Derrota();
        }
    }

    void Pag7Encontro()
    {
        Console.Clear();
        Console.WriteLine("Vocês encontram uma criatura amigável disposta a ajudar na jornada!");
        Console.WriteLine("Continua...");
    }

    void Pag8Vitoria()
    {
        Console.Clear();
        Console.WriteLine("Parabéns! Vocês resolveram o enigma e seguiram em frente na jornada com sucesso!");
    }

/*int[,] matriz = new int[3,3];

int tam0 = 3; // quantidade de linhas
int tam1 = 3; //quantidade de colunas
//lendo valores
for (int linha = 0 ; linha < tam0 ; linha++ )
{
    for (int coluna = 0 ; coluna < tam1 ; coluna++ )
    {
        Console.WriteLine($"Digite o elemento [{linha},{coluna}] da matriz:");
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
    }    
}
//imprimindo valores
Console.WriteLine("## C0 C1 C2");
for (int linha = 0 ; linha < tam0 ; linha++ )
{   
    Console.Write($"L{linha} ");
    for (int coluna = 0 ; coluna < tam1 ; coluna++ )
    {
        Console.Write(matriz[linha, coluna].ToString("00") + " ");
    }
    Console.WriteLine();
}


*/
/*
// Declaração de um array unidimensional de tamanho 5 do tipo int
int[] array1 = new int[5];

// Declaração e atribuição de um array unidimensional de tamanho 6 do tipo int
int[] array2 = { 1, 2, 3, 4, 5, 6 };

// Declaração de um array multidimensional
int[,] multiArray1 = new int[2, 3];
Console.Clear();


int[,] multiArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

int tam0 = multiArray2.GetLength(0); // quantidade de linhas
int tam1 = multiArray2.GetLength(1); //quantidade de colunas

for (int linha = 0 ; linha < tam0 ; linha++ )
{
    for (int coluna = 0 ; coluna < tam1 ; coluna++ )
    {
        //Escrevendo linha em sequência, uma coluna de cada vez
        Console.Write(multiArray2[linha, coluna] + " ");
    }
    //Terminou de escrever a linha
    Console.WriteLine(); 
}
*/





/*
// Declaração de um array irregular
int[][] jaggedArray = new int[6][];

// Atribuição do primeiro valor de um array irregular
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };



int[,] array2d = {{0,0,0,0},{0,0,0,0},{0,0,0,0}};

int tam0 = array2d.GetLength(0);
int tam1 = array2d.GetLength(1);

for (int i = 0; i < tam0; i++)
{
    for (int j = 0; j < tam1; j++)
    {
        array2d[i,j] = i;
    }
}


for (int i = 0; i < tam0; i++)
{
    for (int j = 0; j < tam1; j++)
    {
        
        Console.Write(array2d[i,j] + "-");
    }
    Console.WriteLine();
}
*/