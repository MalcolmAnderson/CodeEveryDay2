using System;

class Program
{
    static void Main(string[] args)
    {
        int[] input = new int[] { 1, 3, 2, 1 }; // false
        Console.WriteLine(AlmostIncreasingSequence(input));
        input = new int[] { 1, 3, 2 }; // true
        Console.WriteLine(AlmostIncreasingSequence(input));
    }

    static bool AlmostIncreasingSequence(int[] sequence)
    {
        // track last inceasing digit
        // track number of violation
        int last = 0;
        int violations = 0;
        // iterate over the array
        for (int i = 0; i < sequence.Length; i++)
        {

            //      if current > last
            if (sequence[i] > last)
            {
                //          last = current
                last = sequence[i];
                //      else
            }
            else
            {
                //          violations ++
                violations++;
            }
        }
        // if violations > 1
        if (violations > 1)
        {
            //      return false
            return false;
        }
        //  return true
        return true;
    }

}
