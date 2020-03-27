using System;

namespace ND2
{
    class Program
    {


        static void Main(string[] args)
        {
            int multiplier;
            Console.WriteLine();
            Console.WriteLine("You will be introduced with numbers, which consist of unique digits.");
            Console.WriteLine("Even more, this magic number will be multiplied and shown if result is also magic number. Look!");
            Console.WriteLine();

            do
            {
                Console.Write("Choose magic number multiplier (2, 3, 4, 5 or 6): ");
                multiplier = Convert.ToInt32(Console.ReadLine());
            }
            while (multiplier != 2 && multiplier != 3 && multiplier != 4 && multiplier != 5 && multiplier != 6); // kaip tai perdaryt, kad nerasyt keleta kartu?
            Console.WriteLine();

            for (int num = 100000; num <= 999999; num++)
            {
                int num2 = num * multiplier;
                int[] inNum = toArray(num);
                int[] inNumSecond = toArray2(num2);

                bool check = checkForSameDigits(inNum);
                bool checkSecond = checkForSameDigitsSecond(inNumSecond);
                bool check2Array = checkTwoArrays(inNum, inNumSecond);

                if (check == true && checkSecond == true && check2Array == true)
                { Console.WriteLine("Magic number, magic number multiplied which is also magic number: " + num + " " + num2); }
            }





        }


        //make int to array no1
        static int[] toArray(int num)
        {
            int[] magicNumber = new int[6];
            while (num > 0)
            {
                for (int i = 5; i >= 0; i--)
                {
                    int digit = num % 10;
                    magicNumber[i] = digit;
                    num = num / 10;
                }
            }
            return magicNumber;
        }


        //make in to array no2
        static int[] toArray2(int num2)
        {
            int[] magicNumber2 = new int[6];
            while (num2 > 0)
            {
                for (int i = 5; i >= 0; i--)
                {
                    int digit2 = num2 % 10;
                    magicNumber2[i] = digit2;
                    num2 = num2 / 10;
                }
            }
            return magicNumber2;
        }


        //is it magic number?
        static bool checkForSameDigits(int[] inNum)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    if (inNum[i] == inNum[j])
                    { return false; }
                }
            }
            return true;
        }


        //is second number magic?
        static bool checkForSameDigitsSecond(int[] inNumSecond)
        {
            for (int a = 0; a <= 5; a++)
            {
                for (int b = a + 1; b <= 5; b++)
                {
                    if (inNumSecond[a] == inNumSecond[b])
                    { return false; }
                }
            }
            return true;
        }


        //sort arrays and make check if in both arrays are the same numbers

        // KAIP? kaip palygint masyvus jiems nedarius Sort?
        static bool checkTwoArrays(int[] inNum, int[] inNumSecond)
        {
            Array.Sort(inNum);
            Array.Sort(inNumSecond);
            for (int k = 0; k <= 5; k++)
            {
                if (inNum[k] != inNumSecond[k])
                { return false; }
            }
            return true;
        }
    }
}

