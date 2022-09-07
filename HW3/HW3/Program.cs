using System;

namespace HW3
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="args">console call params.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("N = ");

            int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");

            int[] inputedArray = new int[n];
            Random rnd = new Random();
            var minNumber = 1;
            var maxNumber = 26;
            for (int i = 0; i < n; i++)
            {
                inputedArray[i] = rnd.Next(minNumber, maxNumber);
            }

            int evenNumbers = 0;
            int oddNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                if (inputedArray[i] % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }
            }

            int[] evenArray = new int[evenNumbers];
            int[] oddArray = new int[oddNumbers];
            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (inputedArray[i] % 2 == 0)
                {
                    evenArray[evenIndex] = inputedArray[i];
                    evenIndex++;
                }
                else
                {
                    oddArray[oddIndex] = inputedArray[i];
                    oddIndex++;
                }
            }

            for (int i = 0; i < evenNumbers; i++)
            {
            }

            for (int i = 0; i < oddNumbers; i++)
            {
            }

            string letters = "abcdefghijklmnopqrstuvwxyz";
            char[] ctrlList = new char[6] { 'a', 'e', 'i', 'd', 'h', 'j' };
            char[] evenChar = new char[evenNumbers];
            char[] oddChar = new char[oddNumbers];
            int evCapLetQuant = 0;
            int odCapLetQuant = 0;

            for (int index = 0; index < maxNumber; index++)
            {
                for (int i = 0; i < evenNumbers; i++)
                {
                    if (index == evenArray[i])
                    {
                        evenChar[i] = letters[index];
                    }

                    for (int j = 0; j < ctrlList.Length; j++)
                    {
                        bool eq = evenChar[i].Equals(ctrlList[j]);
                        if (eq)
                        {
                            evenChar[i] = char.ToUpper(evenChar[i]);
                            evCapLetQuant++;
                        }
                    }
                }
            }

            var evenStr = string.Join(" ", evenChar);
            Console.WriteLine($"Первый массив: {evenStr}");

            for (int index = 0; index < maxNumber; index++)
            {
                for (int i = 0; i < oddNumbers; i++)
                {
                    if (index == oddArray[i])
                    {
                        oddChar[i] = letters[index];
                    }

                    for (int j = 0; j < ctrlList.Length; j++)
                    {
                        bool eq = oddChar[i].Equals(ctrlList[j]);
                        if (eq)
                        {
                            oddChar[i] = char.ToUpper(oddChar[i]);
                            odCapLetQuant++;
                        }
                    }
                }
            }

            var oddStr = string.Join(" ", oddChar);
            Console.WriteLine($"Второй массив: {oddStr}");

            if (evCapLetQuant > odCapLetQuant)
            {
                Console.WriteLine("В верхнем регистре больше букв в Первом массиве");
            }

            if (evCapLetQuant < odCapLetQuant)
            {
                Console.WriteLine("В верхнем регистре больше букв во Втором массиве");
            }

            if (evCapLetQuant == odCapLetQuant)
            {
                Console.WriteLine("Одинаково");
            }
        }
    }
}