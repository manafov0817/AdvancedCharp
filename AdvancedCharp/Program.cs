using AdvancedCharp.Delegate;
using System;

namespace AdvancedCharp
{
    class Program
    {
        public delegate int Calculator(int number);
        public delegate string StringManipulator(string firstString);
        public delegate T Manipulator<T>(T variable );
        static void Main(string[] args)
        {

            int[] myArray = { 1, 4, 7, 8, 6, 45 };

            Calculator calculator = Divide;

            IntegerFunction(myArray, calculator);

            //foreach (int number in myArray)
            //{
            //    Console.WriteLine(number);
            //}

            string[] stringArray = { "Salam", "Kele", "Necesen", "asdfglkajshflaskdjhf" };


            //StringManipulator stringManipulator = AddBlank;

            //stringManipulator += Inverter;

            //StringFunction(stringArray, stringManipulator);

            //foreach (string @string in stringArray)
            //{
            //    Console.WriteLine(@string);
            //}

            Manipulator<string> stringManipulator = AddBlank; 

            DelegateFunction(stringArray, stringManipulator);

            Manipulator<int> integerManipulator = Sum;



        }

        public static int Sum(int number)
        {
            return number + 100;
        }

        public static int Divide(int number)
        {
            return number / 5;
        }      
    
        public static string Inverter(string invertString)
        {
            string returnString = "";

            for (int i = 0; i < invertString.Length; i++)
            {
                returnString += invertString[^(i + 1)];
            }

            return returnString;
        }

        public static string AddBlank(string invertString)
        {
            string returnString = "";

            for (int i = 0; i < invertString.Length; i++)
            {
                returnString += invertString[i ]+" ";
            }

            return returnString;
        }

        public static void StringFunction(string[] stringArray, StringManipulator manipulator)
        {

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = manipulator(stringArray[i]);
            }
        }

        public static void IntegerFunction(int[] array, Calculator cal)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = cal(array[i]);
            }
        }

        public static void DelegateFunction<T>(T[] array, Manipulator<T> cal)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = cal(array[i]);
            }
        }

    }
}
