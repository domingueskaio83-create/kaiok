using System;
class Program
{
    static int Menor(int[,] matriz)
    {
        int menor = matriz[0, 0];
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
                if (matriz[i, j] < menor)
                    menor = matriz[i, j];
        return menor;
    }
    static void Main()
    {
        int[,] matriz = { { 4, 8, 2 }, { 10, 5, 7 } };
        Console.WriteLine("Menor valor: " + Menor(matriz));
    }
}