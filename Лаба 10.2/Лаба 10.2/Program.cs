using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] A = { { 0, 20, -1, 50, -1 },
                     { 20, 0, 30, -1, -1 },
                     { -1, 30, 0, 40, -1 },
                     { 50, -1, 40, 0, 10 },
                     { -1, -1, -1, 10, 0 } };

        int startCity = 0;
        int maxDistance = 200;

        bool[] reachableCities = new bool[A.GetLength(0)]; 
        reachableCities[startCity] = true;

        for (int distance = 1; distance <= maxDistance; distance++)
        {
            bool[] newReachableCities = new bool[A.GetLength(0)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (reachableCities[i])
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        if (A[i, j] >= 0 && A[i, j] <= maxDistance - distance)
                        {
                            newReachableCities[j] = true;
                        }
                    }
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (newReachableCities[i])
                {
                    reachableCities[i] = true;
                }
            }
        }

        Console.WriteLine("Города, в которые можно добраться по суммарному пути не длиннее " + maxDistance + " км:");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (reachableCities[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}

