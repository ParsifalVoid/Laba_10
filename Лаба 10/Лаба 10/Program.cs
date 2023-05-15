using System;

class Program
{
    static void Main(string[] args)
    {
        int[] bills = new int[100];
        Random random = new Random();

        for (int i = 0; i < bills.Length; i++)
        {
            bills[i] = random.Next(1, 8) switch
            {
                1 => 1,
                2 => 2,
                3 => 5,
                4 => 10,
                5 => 20,
                6 => 50,
                _ => 100
            };
        }

        int[] counts = new int[7];

        for (int i = 0; i < bills.Length; i++)
        {
            switch (bills[i])
            {
                case 1:
                    counts[0]++;
                    break;
                case 2:
                    counts[1]++;
                    break;
                case 5:
                    counts[2]++;
                    break;
                case 10:
                    counts[3]++;
                    break;
                case 20:
                    counts[4]++;
                    break;
                case 50:
                    counts[5]++;
                    break;
                case 100:
                    counts[6]++;
                    break;
            }
        }

        int[] sortedBills = new int[100];
        int currentIndex = 0;

        for (int i = 0; i < counts.Length; i++)
        {
            for (int j = 0; j < counts[i]; j++)
            {
                sortedBills[currentIndex] = (i + 1) switch
                {
                    1 => 1,
                    2 => 2,
                    3 => 5,
                    4 => 10,
                    5 => 20,
                    6 => 50,
                    _ => 100
                };

                currentIndex++;
            }
        }

        Console.WriteLine("Отсортированный массив купюр:");
        for (int i = 0; i < sortedBills.Length; i++)
        {
            Console.Write(sortedBills[i] + " ");
        }
    }
}
