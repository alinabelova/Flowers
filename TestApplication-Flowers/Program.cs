using System;

namespace TestApplication_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;
            int x = 0;
            int i = 0;
            decimal result = 0;
            bool condition = false;

            Console.WriteLine("Enter N and K:");
            string nk = Console.ReadLine();
            StringHelper.ValidateEmptyString(ref nk, "N and K");
            string[] NandK = StringHelper.SplitStr(nk, 2, "N and K");

            do
            {
                StringHelper.ConverStrToNumber(NandK[0], out n, condition, "N", "N must be greater 0");
                condition = n < 1;
            } while (condition);

            do
            {
                StringHelper.ConverStrToNumber(NandK[1], out k, condition, "K", "K must be greater 0 and less 101");
                condition = k < 1 && k >= 100;
            } while (condition);   

            decimal[] c = new decimal[n];

            Console.WriteLine("Enter C[N]:");
            string priceNumbers = Console.ReadLine();
            StringHelper.ValidateEmptyString(ref priceNumbers, "c-numbers");
            string[] priceNumberSplit = StringHelper.SplitStr(priceNumbers, n, "c-numbers");
            
            foreach (string s in priceNumberSplit)
            {
                if (s.Trim() != "")
                {
                    do
                    {
                        StringHelper.ConverStrToNumber(s, out c[i], condition, "C[" + i + "]", "C[" + i + "] must be less or equal 1000,000");
                        condition = c[i] >= 1000;
                    } while (condition);
                    i++;
                }
            }
            
            for (int j = 0; j < n; j++)
            {
                if (j >= k)
                {
                    x = j / k;
                }
                result += (x + 1) * c[j];
            }
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
