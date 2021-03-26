using System;

namespace Practice3
{
    class Program
    {
        private static int Lower { get; set; }
        private static int Upper { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Set the lower value of the range!");
            Lower = Validator.GetValidatedInput();

            Console.WriteLine("Set the upper value of the range!");
            Upper = Validator.GetValidatedInput();

            if (IsRangeGoodToCreateArray(Lower, Upper))
            {
                int[] newArray = (int[])GetArrayOfNaturalNumbers(Lower, Upper);
                GetSumOfNumbersDevidableOn3AndNotDevidableOn5(newArray);
            }
            else
            {
                Console.WriteLine("Less then 11 values range, exit");
            }
             Console.ReadKey();
        }

        private static bool IsRangeGoodToCreateArray(int lowere, int uppere)
        {
            return ((Upper - Lower + 1) > 10);
        }

        private static Array GetArrayOfNaturalNumbers(int lower, int upper)
        {
            int[] numbersArray = new int[Upper - Lower + 1];
            int i = 0;
            do
            {
               numbersArray[i] = Lower + i;
               Console.WriteLine("Array element with i={0} is {1}", i, numbersArray[i]);
               i++;
            }
            while ((Lower + i <= Upper) && (i <= Upper - Lower));
            return numbersArray;
        }

        private static void GetSumOfNumbersDevidableOn3AndNotDevidableOn5(int [] array)
        {
            int sum = 0;
            for (int i = 0; i < Upper - Lower; i++)
            {
                if ((array[i] % 3 == 0) && (array[i] % 5 != 0))
                {
                    sum = sum + array[i];
                }
            }
            Console.WriteLine("Sum of elements devidable on 3 and not devidable on 5 is : " + sum);
        }
    }
}