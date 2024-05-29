


int[,] tela = new int[4, 4];
int[,] jogo = new int[4, 4];
int acertos = 0;

Random gerador = new Random();

int lin, col;
//Vamos gerar os pares de números e adicionar
//na matriz jogo
for (int i = 1; i <= 8; i++)
{
    for (int n = 0; n < 2; n++)
    {
        do
        {
            lin = gerador.Next(0, 4);
            col = gerador.Next(0, 4);
        } while (jogo[lin, col] != 0);

        jogo[lin, col] = i;
    }
}

do
{
    //Impressão
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            Console.Write("{0} ", tela[j, k]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    int lin1, col1;
    Console.WriteLine("Entre com a linha [1, 4]");
    lin1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Entre com a coluna [1, 4]");
    col1 = int.Parse(Console.ReadLine());

    lin1--; //diminuir, pois o usuário não sabe
    col1--; //que existe linha e coluna zero
            //Atribuir o valor da matriz jogo na tela
    tela[lin1, col1] = jogo[lin1, col1];

    //Impressão
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            Console.Write("{0} ", tela[j, k]);
        }
        Console.WriteLine("");
    }
    Console.WriteLine();

    int lin2, col2;
    Console.WriteLine("Entre com a linha [1, 4]");
    lin2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Entre com a coluna [1, 4]");
    col2 = int.Parse(Console.ReadLine());

    lin2--; //diminuir, pois o usuário não sabe
    col2--; //que existe linha e coluna zero
            //Atribuir o valor da matriz jogo na tela
    tela[lin2, col2] = jogo[lin2, col2];

    //Impressão
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            Console.Write("{0} ", tela[j, k]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    if (tela[lin1, col1] == tela[lin2, col2])
    {
        acertos++;
    }
    else //Caso não tenha acertado o par
    {
        tela[lin1, col1] = 0;
        tela[lin2, col2] = 0;
    }

} while (acertos < 8);
 