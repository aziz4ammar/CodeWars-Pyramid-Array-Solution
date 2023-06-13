using System;

public class Kata
{
    public static int[][] Pyramid(int n)
    {
        int[][] pyramid = new int[n][];

        for (int i = 0; i < n; i++)
        {
            pyramid[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                pyramid[i][j] = 1;
            }
        }

        return pyramid;
    }
}
