using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication_Flowers
{
    public static class StringHelper
    {
        /// <summary>
        /// Преобразует строку в число
        /// </summary>
        /// <param name="numberString">строка, представляющая число</param>
        /// <param name="number">число, в которое будет преобразована строка</param>
        /// <param name="condition">условие, проверяющее ограничение числа</param>
        /// <param name="symbol">обозначение числа</param>
        /// <param name="error">строка с ошибкой</param>
        public static void ConverStrToNumber(string numberString, out int number, bool condition, string symbol,
            string error)
        {
            while (true)
            {
                if (!Int32.TryParse(numberString, out number))
                {
                    Console.Write("Error! Number " + symbol + " can not be converted.");
                    Console.WriteLine("Please enter " + symbol + " again:");
                }
                else if (condition)
                {
                    condition = false;
                    Console.Write("Error: " + error + ". Please enter " + symbol + " again:");
                }
                else
                    break;
                numberString = Console.ReadLine();
            }
        }

        /// <summary>
        /// Преобразует строку в число
        /// </summary>
        /// <param name="numberString">строка, представляющая число</param>
        /// <param name="number">число, в которое будет преобразована строка</param>
        /// <param name="condition">условие, проверяющее ограничение числа</param>
        /// <param name="symbol">обозначение числа</param>
        /// <param name="error">строка с ошибкой</param>
        public static void ConverStrToNumber(string numberString, out decimal number, bool condition, string symbol,
            string error)
        {
            while (true)
            {
                if (!Decimal.TryParse(numberString, out number))
                {
                    Console.Write("Error! Number " + symbol + " can not be converted.");
                    Console.WriteLine("Please enter " + symbol + " again:");
                }
                else if (condition)
                {
                    condition = false;
                    Console.Write("Error: " + error + ". Please enter " + symbol + " again:");
                }
                else
                    break;
                numberString = Console.ReadLine();
            }
        }

        /// <summary>
        /// Проверяет введенную строку на пустоту
        /// </summary>
        /// <param name="validateStr">строка для проверки</param>
        /// <param name="strInfo">информация о повторном вводе</param>
        public static void ValidateEmptyString(ref string validateStr, string strInfo)
        {
            while (String.IsNullOrEmpty(validateStr))
            {
                Console.WriteLine("Error! You entered an empty string.");
                Console.WriteLine("Please enter " + strInfo + " again:");
                validateStr = Console.ReadLine();
            }
        }

        /// <summary>
        /// Разделение строки на массив
        /// </summary>
        /// <param name="strForSplit">строка, которую необходимо разделить</param>
        /// <param name="strLength">длина строки</param>
        /// <param name="strInfo">информация о повторном вводе</param>
        /// <returns></returns>
        public static string[] SplitStr(string strForSplit, int strLength, string strInfo)
        {
            string[] numberArray = strForSplit.Split(' ', '\t', '\n');
            while (numberArray.Length != strLength)
            {
                Console.WriteLine("Error! You  must enter " + strLength + " numbers.");
                Console.WriteLine("Please enter " + strInfo + " again:");
                strForSplit = Console.ReadLine();
                ValidateEmptyString(ref strForSplit, strInfo);
                numberArray = strForSplit.Split(' ', '\t', '\n');
            }
            return numberArray;
        }
    }
}
