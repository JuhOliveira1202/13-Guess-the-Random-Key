using System;

class Program
{
    public static void Main(string[] args)
    {
        int n, y;

        n = 6;
        y = 6;

        //ler a chave criado pelo utilizador
        int[] vec1 = new int[n];
        Console.WriteLine("Digite os números da sua chave! \nEntre 1 e 49!");

        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("Posição " + i + " = ");
                vec1[i] = Convert.ToInt32(Console.ReadLine());

            } while (vec1[i] < 1 || vec1[i] > 49);
        }
        
        Console.WriteLine();

        //inserir uma chave aleatória por parte do programa
        int[] vec2 = new int[y];
        Random rnd = new Random();
        int z;
        for (int j = 0; j < y; j++)
        {
            vec2[j] = rnd.Next(49); 
            Console.Write(vec2[j]);

            //não haver números repetidos
            for(int k = 0; k < j; k++)                                      
            {                                                               
                if (vec2[k] == vec2[j])                                     
                {
                    j--;
                    break;
                }
            }
        }

        Console.WriteLine();

        //ver se existe números compatíveis
        int cont = 0;
        for (int i = 0; i < n; i++)
        {
            bool found = false;
            for (int k = 0; k < i; k++)
            {
                if (vec1[i] == vec1[k])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                for (int j = 0; j < y; j++)
                {
                    if (vec1[i] == vec2[j])
                    {
                        cont++;
                        break;
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("O programa tem " + cont + " números comuns.");

        //ordenar os números
        Array.Sort(vec1);
        Console.Write("Chave ordenada [");
        foreach (int i in vec1) Console.Write(i + "|");
        Console.WriteLine("]");

        Console.WriteLine();
        Array.Sort(vec2);
        Console.Write("Chave aleatória ordenada [");
        foreach (int j in vec2) Console.Write(j + "|");
        Console.WriteLine("]");

    }
}
