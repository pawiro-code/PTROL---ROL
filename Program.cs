using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            int tmp = int.Parse(s[1]);
            int[] tab = new int[int.Parse(s[0])];

            for (int j=0; j < int.Parse(s[0])-1; j++)
            {
                tab[j] = int.Parse(s[j + 2]);

            }
            tab[int.Parse(s[0]) - 1] = tmp;
            
           

            for (int j = 0; j < tab.Length; j++)
            {
                Console.Write(tab[j] + " ");

            }
            Console.WriteLine();

        }

       
    }
}
