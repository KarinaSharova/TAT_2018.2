using System;

namespace dev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence;

            Console.Write("Enter any sequence of symbols\n");
            sequence = Console.ReadLine();

            int symbolsCount = sequence.Length;
            Console.Write("Count of symbols\n");
            Console.WriteLine(symbolsCount);

            int numberOfNotTheSame = 0;

            if (sequence.Length > 1) 
            {
                for (var i = 1; i < sequence.Length; i++) 
                {
                    var substring = sequence.Remove(i, sequence.Length - i); 
                    var index = substring.IndexOf(sequence[i]); 

                    if (index == -1) 
                    {
                        numberOfNotTheSame = substring.Length + 1;
                    }
                    else 
                    {
                        sequence = sequence.Remove(index, 1);
                    }
                }
            }
            else
            {
                numberOfNotTheSame++;
            }

            Console.Write("Count of not the same symbols\n");

            Console.WriteLine(numberOfNotTheSame);
            Console.ReadKey();
        }
    }
}
