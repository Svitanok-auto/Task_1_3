using System;

namespace Practice3
{
    public class Program
    {
        public static int LowerBorder { get; set; }
        public static int UpperBorder { get; set; }
        public static void Main(string[] args)
        {
            Console.WriteLine("Set the lower value of the range!");
            LowerBorder = Validator.GetValidatedInput();

            Console.WriteLine("\nSet the upper value of the range!");
            UpperBorder = Validator.GetValidatedInput();

            if (IsRangeGoodToCreateArray(LowerBorder, UpperBorder))
            {
                int[] newArray = GetArrayOfNaturalNumbers(LowerBorder, UpperBorder);
                GetSumOfNumbersDevidableOn3AndNotDevidableOn5(newArray);
            }
            else
            {
                Console.WriteLine("Should be more than 10 values range, exit");
            }
             Console.ReadKey();
        }

        private static bool IsRangeGoodToCreateArray(int lowerBorder, int upperBorder)
        {
            return ((UpperBorder - LowerBorder + 1) > 10);
        }

        private static int[] GetArrayOfNaturalNumbers(int lowerBorder, int upperBorder)
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
            while ((LowerBorder + i <= UpperBorder) && (i <= numbersArray.Length));
            return numbersArray;
        }

        private static void GetSumOfNumbersDevidableOn3AndNotDevidableOn5(int [] array)
        {
            int sumOfNumbersDevidableOn3AndNotDevidableOn5 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 3 == 0) && (array[i] % 5 != 0))
                {
                    sumOfNumbersDevidableOn3AndNotDevidableOn5 = sumOfNumbersDevidableOn3AndNotDevidableOn5 + array[i];
                }
            }
            Console.WriteLine("\nSum of elements devidable on 3 and not devidable on 5 is : " + sumOfNumbersDevidableOn3AndNotDevidableOn5);
        }
    }
}