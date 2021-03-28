using System;

namespace Practice3
{
    class Program
    {
        private static int LowerBorder { get; set; }
        private static int UpperBorder { get; set; }
        private static int SumOfNumbersDevidableOn3AndNotDevidableOn5 { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Set the lower value of the range!");
            LowerBorder = Validator.GetValidatedInput();

            Console.WriteLine("\nSet the upper value of the range!");
            UpperBorder = Validator.GetValidatedInput();

            if (IsRangeGoodToCreateArray(LowerBorder, UpperBorder))
            {
                int[] newArray = (int[])GetArrayOfNaturalNumbers(LowerBorder, UpperBorder);
                GetSumOfNumbersDevidableOn3AndNotDevidableOn5(newArray);
            }
            else
            {
                Console.WriteLine("Less then 11 values range, exit");
            }
             Console.ReadKey();
        }

        private static bool IsRangeGoodToCreateArray(int lowerBorder, int upperBorder)
        {
            return ((UpperBorder - LowerBorder + 1) > 10);
        }

        private static Array GetArrayOfNaturalNumbers(int lowerBorder, int upperBorder)
        {
            Console.WriteLine("\nArray is below");
            int[] numbersArray = new int[UpperBorder - LowerBorder + 1];
            int i = 0;
            do
            {
               numbersArray[i] = LowerBorder + i;
               Console.WriteLine("Array element with i={0} is {1}", i, numbersArray[i]);
               i++;
            }
            while ((LowerBorder + i <= UpperBorder) && (i <= UpperBorder - LowerBorder));
            return numbersArray;
        }

        private static void GetSumOfNumbersDevidableOn3AndNotDevidableOn5(int [] array)
        {
            for (int i = 0; i < UpperBorder - LowerBorder; i++)
            {
                if ((array[i] % 3 == 0) && (array[i] % 5 != 0))
                {
                    SumOfNumbersDevidableOn3AndNotDevidableOn5 = SumOfNumbersDevidableOn3AndNotDevidableOn5 + array[i];
                }
            }
            Console.WriteLine("\nSum of elements devidable on 3 and not devidable on 5 is : " + SumOfNumbersDevidableOn3AndNotDevidableOn5);
        }
    }
}